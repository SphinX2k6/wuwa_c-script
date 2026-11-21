using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag
{
	// Token: 0x02005B8E RID: 23438
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SplineConstrainedDragModel : ModelBase
	{
		// Token: 0x06039A3B RID: 236091 RVA: 0x010311DE File Offset: 0x0102F3DE
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06039A3C RID: 236092 RVA: 0x010311E4 File Offset: 0x0102F3E4
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

		// Token: 0x06039A3D RID: 236093 RVA: 0x010312E0 File Offset: 0x0102F4E0
		public bool GetDragActorPlayActive()
		{
			return this.DragActorPlayActive;
		}

		// Token: 0x06039A3E RID: 236094 RVA: 0x010312E8 File Offset: 0x0102F4E8
		public void SetDragActorPlayActive(bool active)
		{
			if (this.DragActorPlayActive == active)
			{
				return;
			}
			this.DragActorPlayActive = active;
			EventSystem.Instance.Emit<bool>(EEventName.DragActorPlayActivationChanged, active);
		}

		// Token: 0x06039A3F RID: 236095 RVA: 0x0103130C File Offset: 0x0102F50C
		public void BroadcastDragActorPlayConditionRecheck()
		{
			if (!this.DragActorPlayActive)
			{
				return;
			}
			EventSystem.Instance.Emit(EEventName.DragActorPlayConditionRecheck);
		}

		// Token: 0x06039A40 RID: 236096 RVA: 0x01031327 File Offset: 0x0102F527
		public void RegisterKuroSplineConstrainedDrag(string key, IKuroSplineConstrainedDrag kuroSplineConstrainedDrag)
		{
			this.KuroSplineConstrainedDrags[key] = kuroSplineConstrainedDrag;
		}

		// Token: 0x06039A41 RID: 236097 RVA: 0x01031338 File Offset: 0x0102F538
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

		// Token: 0x06039A42 RID: 236098 RVA: 0x01031380 File Offset: 0x0102F580
		[return: Nullable(2)]
		public IKuroSplineConstrainedDrag GetKuroSplineConstrainedDrag(string key)
		{
			return this.KuroSplineConstrainedDrags.GetValueOrDefault(key);
		}

		// Token: 0x06039A43 RID: 236099 RVA: 0x0103138E File Offset: 0x0102F58E
		public IReadOnlyDictionary<string, IKuroSplineConstrainedDrag> GetAllKuroSplineConstrainedDrags()
		{
			return this.KuroSplineConstrainedDrags;
		}

		// Token: 0x06039A44 RID: 236100 RVA: 0x01031396 File Offset: 0x0102F596
		[NullableContext(2)]
		public IKuroSplineConstrainedDrag GetActiveSplineConstrainedDrag()
		{
			return this.ActiveDrag;
		}

		// Token: 0x06039A45 RID: 236101 RVA: 0x0103139E File Offset: 0x0102F59E
		public EDragSource GetActiveDragSource()
		{
			return this.ActiveDragSource;
		}

		// Token: 0x06039A46 RID: 236102 RVA: 0x010313A6 File Offset: 0x0102F5A6
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

		// Token: 0x06039A47 RID: 236103 RVA: 0x010313B9 File Offset: 0x0102F5B9
		[NullableContext(2)]
		public void SetActiveSplineConstrainedDrag(IKuroSplineConstrainedDrag drag, EDragSource source)
		{
			this.ActiveDrag = drag;
			this.ActiveDragSource = ((drag == null) ? EDragSource.None : source);
		}

		// Token: 0x06039A48 RID: 236104 RVA: 0x010313CF File Offset: 0x0102F5CF
		[return: Nullable(2)]
		public ISelectionMatCacheEntry GetSelectionMatCacheEntry(string daPath)
		{
			return this.SelectionMatDataCache.GetValueOrDefault(daPath);
		}

		// Token: 0x06039A49 RID: 236105 RVA: 0x010313E0 File Offset: 0x0102F5E0
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

		// Token: 0x06039A4A RID: 236106 RVA: 0x0103143C File Offset: 0x0102F63C
		public void SetSelectionMatAsset(string daPath, [Nullable(2)] ItemMaterialControllerActorData asset)
		{
			ISelectionMatCacheEntry valueOrDefault = this.SelectionMatDataCache.GetValueOrDefault(daPath);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.Asset = asset;
		}

		// Token: 0x06039A4B RID: 236107 RVA: 0x01031464 File Offset: 0x0102F664
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

		// Token: 0x06039A4C RID: 236108 RVA: 0x010314EC File Offset: 0x0102F6EC
		public int? GetSelectionMatHandle()
		{
			return this.SelectionMatHandle;
		}

		// Token: 0x06039A4D RID: 236109 RVA: 0x010314F4 File Offset: 0x0102F6F4
		public void SetSelectionMatHandle(int? handle)
		{
			this.SelectionMatHandle = handle;
		}

		// Token: 0x06039A4E RID: 236110 RVA: 0x010314FD File Offset: 0x0102F6FD
		[NullableContext(2)]
		public string GetTitleTid()
		{
			return this.TitleTid;
		}

		// Token: 0x06039A4F RID: 236111 RVA: 0x01031505 File Offset: 0x0102F705
		[NullableContext(2)]
		public string GetDescTid()
		{
			return this.DescTid;
		}

		// Token: 0x06039A50 RID: 236112 RVA: 0x0103150D File Offset: 0x0102F70D
		[NullableContext(2)]
		public void SetTitleTid(string tid)
		{
			this.TitleTid = tid;
		}

		// Token: 0x06039A51 RID: 236113 RVA: 0x01031516 File Offset: 0x0102F716
		[NullableContext(2)]
		public void SetDescTid(string tid)
		{
			this.DescTid = tid;
		}

		// Token: 0x06039A52 RID: 236114 RVA: 0x0103151F File Offset: 0x0102F71F
		[NullableContext(2)]
		public string GetHintTid()
		{
			return this.HintTid;
		}

		// Token: 0x06039A53 RID: 236115 RVA: 0x01031527 File Offset: 0x0102F727
		[NullableContext(2)]
		public void SetHintTid(string tid)
		{
			this.HintTid = tid;
		}

		// Token: 0x06039A54 RID: 236116 RVA: 0x01031530 File Offset: 0x0102F730
		public float GetGamepadAxisX()
		{
			return this.GamepadAxisX;
		}

		// Token: 0x06039A55 RID: 236117 RVA: 0x01031538 File Offset: 0x0102F738
		public float GetGamepadAxisY()
		{
			return this.GamepadAxisY;
		}

		// Token: 0x06039A56 RID: 236118 RVA: 0x01031540 File Offset: 0x0102F740
		public void SetGamepadAxisX(float value)
		{
			this.GamepadAxisX = value;
		}

		// Token: 0x06039A57 RID: 236119 RVA: 0x01031549 File Offset: 0x0102F749
		public void SetGamepadAxisY(float value)
		{
			this.GamepadAxisY = value;
		}

		// Token: 0x06039A58 RID: 236120 RVA: 0x01031552 File Offset: 0x0102F752
		public bool GetGamepadDragPaused()
		{
			return this.GamepadDragPaused;
		}

		// Token: 0x06039A59 RID: 236121 RVA: 0x0103155A File Offset: 0x0102F75A
		public void SetGamepadDragPaused(bool paused)
		{
			this.GamepadDragPaused = paused;
		}

		// Token: 0x06039A5A RID: 236122 RVA: 0x01031563 File Offset: 0x0102F763
		public void AcquireForbidEvalDisable()
		{
			this.ForbidEvalDisableRefCount++;
			if (this.ForbidEvalDisableRefCount == 1)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
			}
		}

		// Token: 0x06039A5B RID: 236123 RVA: 0x0103158C File Offset: 0x0102F78C
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

		// Token: 0x06039A5C RID: 236124 RVA: 0x010315BE File Offset: 0x0102F7BE
		public void SetDisableExit(bool disable)
		{
			this.DisableExit = disable;
		}

		// Token: 0x06039A5D RID: 236125 RVA: 0x010315C7 File Offset: 0x0102F7C7
		public bool GetDisableExit()
		{
			return this.DisableExit;
		}

		// Token: 0x17006DCC RID: 28108
		// (get) Token: 0x06039A5E RID: 236126 RVA: 0x010315CF File Offset: 0x0102F7CF
		public static SplineConstrainedDragModel Instance
		{
			get
			{
				return SplineConstrainedDragModel._Instance;
			}
		}

		// Token: 0x06039A5F RID: 236127 RVA: 0x010315D6 File Offset: 0x0102F7D6
		public static SplineConstrainedDragModel GetOrCreateInstance()
		{
			if (SplineConstrainedDragModel._Instance == null)
			{
				SplineConstrainedDragModel.CreateInstance();
			}
			return SplineConstrainedDragModel._Instance;
		}

		// Token: 0x06039A60 RID: 236128 RVA: 0x010315EA File Offset: 0x0102F7EA
		public static bool CreateInstance()
		{
			if (SplineConstrainedDragModel._Instance != null)
			{
				return true;
			}
			SplineConstrainedDragModel._Instance = new SplineConstrainedDragModel();
			return true;
		}

		// Token: 0x06039A61 RID: 236129 RVA: 0x01031600 File Offset: 0x0102F800
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039A62 RID: 236130 RVA: 0x01031602 File Offset: 0x0102F802
		public static void ResetStaticDefaultValue()
		{
			SplineConstrainedDragModel._Instance = null;
		}

		// Token: 0x06039A63 RID: 236131 RVA: 0x0103160A File Offset: 0x0102F80A
		static SplineConstrainedDragModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineConstrainedDragModel.CreateStaticDefaultValue), new Action(SplineConstrainedDragModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E6B9 RID: 124601
		private bool DragActorPlayActive;

		// Token: 0x0401E6BA RID: 124602
		private readonly Dictionary<string, IKuroSplineConstrainedDrag> KuroSplineConstrainedDrags = new Dictionary<string, IKuroSplineConstrainedDrag>();

		// Token: 0x0401E6BB RID: 124603
		[Nullable(2)]
		private IKuroSplineConstrainedDrag ActiveDrag;

		// Token: 0x0401E6BC RID: 124604
		private EDragSource ActiveDragSource;

		// Token: 0x0401E6BD RID: 124605
		private readonly Dictionary<string, ISelectionMatCacheEntry> SelectionMatDataCache = new Dictionary<string, ISelectionMatCacheEntry>();

		// Token: 0x0401E6BE RID: 124606
		private int? SelectionMatHandle;

		// Token: 0x0401E6BF RID: 124607
		private float GamepadAxisX;

		// Token: 0x0401E6C0 RID: 124608
		private float GamepadAxisY;

		// Token: 0x0401E6C1 RID: 124609
		private bool GamepadDragPaused;

		// Token: 0x0401E6C2 RID: 124610
		[Nullable(2)]
		private string TitleTid;

		// Token: 0x0401E6C3 RID: 124611
		[Nullable(2)]
		private string DescTid;

		// Token: 0x0401E6C4 RID: 124612
		[Nullable(2)]
		private string HintTid;

		// Token: 0x0401E6C5 RID: 124613
		private int ForbidEvalDisableRefCount;

		// Token: 0x0401E6C6 RID: 124614
		public readonly UKuroHitResult KuroHitResult = new UKuroHitResult();

		// Token: 0x0401E6C7 RID: 124615
		public readonly Vector TempPointerPosition = Vector.Create();

		// Token: 0x0401E6C8 RID: 124616
		public readonly Vector TempBeginScreenPosition = Vector.Create();

		// Token: 0x0401E6C9 RID: 124617
		public readonly Vector LastPointerPosition = Vector.Create();

		// Token: 0x0401E6CA RID: 124618
		public readonly Vector TempPointerScreenDelta = Vector.Create();

		// Token: 0x0401E6CB RID: 124619
		public readonly Vector TempGamepadScreenDelta = Vector.Create();

		// Token: 0x0401E6CC RID: 124620
		public FVector2D TempActorScreenPos2D = new FVector2D();

		// Token: 0x0401E6CD RID: 124621
		private bool DisableExit;

		// Token: 0x0401E6CE RID: 124622
		[Nullable(2)]
		private static SplineConstrainedDragModel _Instance;
	}
}
