using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag
{
	// Token: 0x02006A31 RID: 27185
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SplineConstrainedDragModel : ModelBase
	{
		// Token: 0x060439ED RID: 276973 RVA: 0x0108C9D6 File Offset: 0x0108ABD6
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060439EE RID: 276974 RVA: 0x0108C9DC File Offset: 0x0108ABDC
		protected override bool OnClear()
		{
			foreach (KeyValuePair<string, IKuroSplineConstrainedDrag> keyValuePair in this.KuroSplineConstrainedDrags)
			{
				string text;
				IKuroSplineConstrainedDrag kuroSplineConstrainedDrag;
				keyValuePair.Deconstruct(out text, out kuroSplineConstrainedDrag);
				kuroSplineConstrainedDrag.Clear();
			}
			this.KuroSplineConstrainedDrags.Clear();
			this.ActiveDrag = null;
			this.ActiveDragSource = EDragSource.None;
			this.SelectionMatDataCache.Clear();
			this.SelectionMatHandle = null;
			this.GamepadAxisX = 0f;
			this.GamepadAxisY = 0f;
			this.GamepadDragPaused = false;
			this.TitleTid = null;
			this.DescTid = null;
			this.HintTid = null;
			this.LastPointerPosition.Reset();
			this.DragActorPlayActive = false;
			if (this.ForbidEvalDisableRefCount > 0)
			{
				this.ForbidEvalDisableRefCount = 0;
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
			}
			this.DisableExit = false;
			return true;
		}

		// Token: 0x060439EF RID: 276975 RVA: 0x0108CAD8 File Offset: 0x0108ACD8
		public bool GetDragActorPlayActive()
		{
			return this.DragActorPlayActive;
		}

		// Token: 0x060439F0 RID: 276976 RVA: 0x0108CAE0 File Offset: 0x0108ACE0
		public void SetDragActorPlayActive(bool active)
		{
			if (this.DragActorPlayActive == active)
			{
				return;
			}
			this.DragActorPlayActive = active;
			EventSystem.Instance.Emit<bool>(EEventName.DragActorPlayActivationChanged, active);
		}

		// Token: 0x060439F1 RID: 276977 RVA: 0x0108CB04 File Offset: 0x0108AD04
		public void BroadcastDragActorPlayConditionRecheck()
		{
			if (!this.DragActorPlayActive)
			{
				return;
			}
			EventSystem.Instance.Emit(EEventName.DragActorPlayConditionRecheck);
		}

		// Token: 0x060439F2 RID: 276978 RVA: 0x0108CB1F File Offset: 0x0108AD1F
		public void RegisterKuroSplineConstrainedDrag(string key, IKuroSplineConstrainedDrag kuroSplineConstrainedDrag)
		{
			this.KuroSplineConstrainedDrags[key] = kuroSplineConstrainedDrag;
		}

		// Token: 0x060439F3 RID: 276979 RVA: 0x0108CB30 File Offset: 0x0108AD30
		public void UnregisterKuroSplineConstrainedDrag(string key)
		{
			IKuroSplineConstrainedDrag valueOrDefault = this.KuroSplineConstrainedDrags.GetValueOrDefault(key);
			if (valueOrDefault == null)
			{
				return;
			}
			if (this.ActiveDrag == valueOrDefault)
			{
				this.ActiveDrag = null;
				this.ActiveDragSource = EDragSource.None;
			}
			valueOrDefault.Clear();
			this.KuroSplineConstrainedDrags.Remove(key);
		}

		// Token: 0x060439F4 RID: 276980 RVA: 0x0108CB78 File Offset: 0x0108AD78
		[return: Nullable(2)]
		public IKuroSplineConstrainedDrag GetKuroSplineConstrainedDrag(string key)
		{
			return this.KuroSplineConstrainedDrags.GetValueOrDefault(key);
		}

		// Token: 0x060439F5 RID: 276981 RVA: 0x0108CB86 File Offset: 0x0108AD86
		public IReadOnlyDictionary<string, IKuroSplineConstrainedDrag> GetAllKuroSplineConstrainedDrags()
		{
			return this.KuroSplineConstrainedDrags;
		}

		// Token: 0x060439F6 RID: 276982 RVA: 0x0108CB8E File Offset: 0x0108AD8E
		[NullableContext(2)]
		public IKuroSplineConstrainedDrag GetActiveSplineConstrainedDrag()
		{
			return this.ActiveDrag;
		}

		// Token: 0x060439F7 RID: 276983 RVA: 0x0108CB96 File Offset: 0x0108AD96
		public EDragSource GetActiveDragSource()
		{
			return this.ActiveDragSource;
		}

		// Token: 0x060439F8 RID: 276984 RVA: 0x0108CB9E File Offset: 0x0108AD9E
		[NullableContext(2)]
		public string GetActiveDragActorKey()
		{
			IKuroSplineConstrainedDrag activeDrag = this.ActiveDrag;
			if (activeDrag == null)
			{
				return null;
			}
			return activeDrag.GetActorKey();
		}

		// Token: 0x060439F9 RID: 276985 RVA: 0x0108CBB1 File Offset: 0x0108ADB1
		[NullableContext(2)]
		public void SetActiveSplineConstrainedDrag(IKuroSplineConstrainedDrag drag, EDragSource source)
		{
			this.ActiveDrag = drag;
			this.ActiveDragSource = ((drag == null) ? EDragSource.None : source);
		}

		// Token: 0x060439FA RID: 276986 RVA: 0x0108CBC7 File Offset: 0x0108ADC7
		[return: Nullable(2)]
		public ISelectionMatCacheEntry GetSelectionMatCacheEntry(string daPath)
		{
			return this.SelectionMatDataCache.GetValueOrDefault(daPath);
		}

		// Token: 0x060439FB RID: 276987 RVA: 0x0108CBD8 File Offset: 0x0108ADD8
		public bool AddSelectionMatRef(string daPath, int holderId)
		{
			ISelectionMatCacheEntry valueOrDefault = this.SelectionMatDataCache.GetValueOrDefault(daPath);
			if (valueOrDefault != null)
			{
				valueOrDefault.RefHolders.Add(holderId);
				return false;
			}
			ISelectionMatCacheEntry value = new SelectionMatCacheEntry
			{
				Asset = null,
				RefHolders = new HashSet<int>
				{
					holderId
				}
			};
			this.SelectionMatDataCache[daPath] = value;
			return true;
		}

		// Token: 0x060439FC RID: 276988 RVA: 0x0108CC34 File Offset: 0x0108AE34
		public void SetSelectionMatAsset(string daPath, [Nullable(2)] ItemMaterialControllerActorData asset)
		{
			ISelectionMatCacheEntry valueOrDefault = this.SelectionMatDataCache.GetValueOrDefault(daPath);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.Asset = asset;
		}

		// Token: 0x060439FD RID: 276989 RVA: 0x0108CC5C File Offset: 0x0108AE5C
		public void RemoveSelectionMatRefByHolder(int holderId)
		{
			foreach (KeyValuePair<string, ISelectionMatCacheEntry> keyValuePair in this.SelectionMatDataCache)
			{
				string text;
				ISelectionMatCacheEntry selectionMatCacheEntry;
				keyValuePair.Deconstruct(out text, out selectionMatCacheEntry);
				string key = text;
				ISelectionMatCacheEntry selectionMatCacheEntry2 = selectionMatCacheEntry;
				if (selectionMatCacheEntry2.RefHolders.Remove(holderId) && selectionMatCacheEntry2.RefHolders.Count == 0)
				{
					this.SelectionMatDataCache.Remove(key);
				}
			}
		}

		// Token: 0x060439FE RID: 276990 RVA: 0x0108CCE4 File Offset: 0x0108AEE4
		public int? GetSelectionMatHandle()
		{
			return this.SelectionMatHandle;
		}

		// Token: 0x060439FF RID: 276991 RVA: 0x0108CCEC File Offset: 0x0108AEEC
		public void SetSelectionMatHandle(int? handle)
		{
			this.SelectionMatHandle = handle;
		}

		// Token: 0x06043A00 RID: 276992 RVA: 0x0108CCF5 File Offset: 0x0108AEF5
		[NullableContext(2)]
		public string GetTitleTid()
		{
			return this.TitleTid;
		}

		// Token: 0x06043A01 RID: 276993 RVA: 0x0108CCFD File Offset: 0x0108AEFD
		[NullableContext(2)]
		public string GetDescTid()
		{
			return this.DescTid;
		}

		// Token: 0x06043A02 RID: 276994 RVA: 0x0108CD05 File Offset: 0x0108AF05
		[NullableContext(2)]
		public void SetTitleTid(string tid)
		{
			this.TitleTid = tid;
		}

		// Token: 0x06043A03 RID: 276995 RVA: 0x0108CD0E File Offset: 0x0108AF0E
		[NullableContext(2)]
		public void SetDescTid(string tid)
		{
			this.DescTid = tid;
		}

		// Token: 0x06043A04 RID: 276996 RVA: 0x0108CD17 File Offset: 0x0108AF17
		[NullableContext(2)]
		public string GetHintTid()
		{
			return this.HintTid;
		}

		// Token: 0x06043A05 RID: 276997 RVA: 0x0108CD1F File Offset: 0x0108AF1F
		[NullableContext(2)]
		public void SetHintTid(string tid)
		{
			this.HintTid = tid;
		}

		// Token: 0x06043A06 RID: 276998 RVA: 0x0108CD28 File Offset: 0x0108AF28
		public float GetGamepadAxisX()
		{
			return this.GamepadAxisX;
		}

		// Token: 0x06043A07 RID: 276999 RVA: 0x0108CD30 File Offset: 0x0108AF30
		public float GetGamepadAxisY()
		{
			return this.GamepadAxisY;
		}

		// Token: 0x06043A08 RID: 277000 RVA: 0x0108CD38 File Offset: 0x0108AF38
		public void SetGamepadAxisX(float value)
		{
			this.GamepadAxisX = value;
		}

		// Token: 0x06043A09 RID: 277001 RVA: 0x0108CD41 File Offset: 0x0108AF41
		public void SetGamepadAxisY(float value)
		{
			this.GamepadAxisY = value;
		}

		// Token: 0x06043A0A RID: 277002 RVA: 0x0108CD4A File Offset: 0x0108AF4A
		public bool GetGamepadDragPaused()
		{
			return this.GamepadDragPaused;
		}

		// Token: 0x06043A0B RID: 277003 RVA: 0x0108CD52 File Offset: 0x0108AF52
		public void SetGamepadDragPaused(bool paused)
		{
			this.GamepadDragPaused = paused;
		}

		// Token: 0x06043A0C RID: 277004 RVA: 0x0108CD5B File Offset: 0x0108AF5B
		public void AcquireForbidEvalDisable()
		{
			this.ForbidEvalDisableRefCount++;
			if (this.ForbidEvalDisableRefCount == 1)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
			}
		}

		// Token: 0x06043A0D RID: 277005 RVA: 0x0108CD84 File Offset: 0x0108AF84
		public void ReleaseForbidEvalDisable()
		{
			if (this.ForbidEvalDisableRefCount <= 0)
			{
				return;
			}
			this.ForbidEvalDisableRefCount--;
			if (this.ForbidEvalDisableRefCount == 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
			}
		}

		// Token: 0x06043A0E RID: 277006 RVA: 0x0108CDB6 File Offset: 0x0108AFB6
		public void SetDisableExit(bool disable)
		{
			this.DisableExit = disable;
		}

		// Token: 0x06043A0F RID: 277007 RVA: 0x0108CDBF File Offset: 0x0108AFBF
		public bool GetDisableExit()
		{
			return this.DisableExit;
		}

		// Token: 0x170098E7 RID: 39143
		// (get) Token: 0x06043A10 RID: 277008 RVA: 0x0108CDC7 File Offset: 0x0108AFC7
		public static SplineConstrainedDragModel Instance
		{
			get
			{
				return SplineConstrainedDragModel._Instance;
			}
		}

		// Token: 0x06043A11 RID: 277009 RVA: 0x0108CDCE File Offset: 0x0108AFCE
		public static SplineConstrainedDragModel GetOrCreateInstance()
		{
			if (SplineConstrainedDragModel._Instance == null)
			{
				SplineConstrainedDragModel.CreateInstance();
			}
			return SplineConstrainedDragModel._Instance;
		}

		// Token: 0x06043A12 RID: 277010 RVA: 0x0108CDE2 File Offset: 0x0108AFE2
		public static bool CreateInstance()
		{
			if (SplineConstrainedDragModel._Instance != null)
			{
				return true;
			}
			SplineConstrainedDragModel._Instance = new SplineConstrainedDragModel();
			return true;
		}

		// Token: 0x06043A13 RID: 277011 RVA: 0x0108CDF8 File Offset: 0x0108AFF8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043A14 RID: 277012 RVA: 0x0108CDFA File Offset: 0x0108AFFA
		public static void ResetStaticDefaultValue()
		{
			SplineConstrainedDragModel._Instance = null;
		}

		// Token: 0x06043A15 RID: 277013 RVA: 0x0108CE02 File Offset: 0x0108B002
		static SplineConstrainedDragModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineConstrainedDragModel.CreateStaticDefaultValue), new Action(SplineConstrainedDragModel.ResetStaticDefaultValue));
		}

		// Token: 0x040234C7 RID: 144583
		private bool DragActorPlayActive;

		// Token: 0x040234C8 RID: 144584
		private readonly Dictionary<string, IKuroSplineConstrainedDrag> KuroSplineConstrainedDrags = new Dictionary<string, IKuroSplineConstrainedDrag>();

		// Token: 0x040234C9 RID: 144585
		[Nullable(2)]
		private IKuroSplineConstrainedDrag ActiveDrag;

		// Token: 0x040234CA RID: 144586
		private EDragSource ActiveDragSource;

		// Token: 0x040234CB RID: 144587
		private readonly Dictionary<string, ISelectionMatCacheEntry> SelectionMatDataCache = new Dictionary<string, ISelectionMatCacheEntry>();

		// Token: 0x040234CC RID: 144588
		private int? SelectionMatHandle;

		// Token: 0x040234CD RID: 144589
		private float GamepadAxisX;

		// Token: 0x040234CE RID: 144590
		private float GamepadAxisY;

		// Token: 0x040234CF RID: 144591
		private bool GamepadDragPaused;

		// Token: 0x040234D0 RID: 144592
		[Nullable(2)]
		private string TitleTid;

		// Token: 0x040234D1 RID: 144593
		[Nullable(2)]
		private string DescTid;

		// Token: 0x040234D2 RID: 144594
		[Nullable(2)]
		private string HintTid;

		// Token: 0x040234D3 RID: 144595
		private int ForbidEvalDisableRefCount;

		// Token: 0x040234D4 RID: 144596
		public readonly UKuroHitResult KuroHitResult = new UKuroHitResult();

		// Token: 0x040234D5 RID: 144597
		public readonly Vector TempPointerPosition = Vector.Create();

		// Token: 0x040234D6 RID: 144598
		public readonly Vector TempBeginScreenPosition = Vector.Create();

		// Token: 0x040234D7 RID: 144599
		public readonly Vector LastPointerPosition = Vector.Create();

		// Token: 0x040234D8 RID: 144600
		public readonly Vector TempPointerScreenDelta = Vector.Create();

		// Token: 0x040234D9 RID: 144601
		public readonly Vector TempGamepadScreenDelta = Vector.Create();

		// Token: 0x040234DA RID: 144602
		public FVector2D TempActorScreenPos2D = new FVector2D();

		// Token: 0x040234DB RID: 144603
		private bool DisableExit;

		// Token: 0x040234DC RID: 144604
		[Nullable(2)]
		private static SplineConstrainedDragModel _Instance;
	}
}
