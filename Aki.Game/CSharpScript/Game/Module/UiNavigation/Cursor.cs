using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200385D RID: 14429
	[NullableContext(1)]
	[Nullable(0)]
	public class Cursor : IStaticVariableResetter
	{
		// Token: 0x060257E7 RID: 153575 RVA: 0x00A8F995 File Offset: 0x00A8DB95
		static Cursor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Cursor.CreateStaticDefaultValue), new Action(Cursor.ResetStaticDefaultValue));
		}

		// Token: 0x17004D04 RID: 19716
		// (get) Token: 0x060257E8 RID: 153576 RVA: 0x00A8F9B4 File Offset: 0x00A8DBB4
		private static Vector TempLocation
		{
			get
			{
				if (Cursor._tempLocation == null)
				{
					Cursor._tempLocation = new Vector();
				}
				return Cursor._tempLocation;
			}
		}

		// Token: 0x17004D05 RID: 19717
		// (get) Token: 0x060257E9 RID: 153577 RVA: 0x00A8F9CC File Offset: 0x00A8DBCC
		private static Rotator OriRotator
		{
			get
			{
				if (Cursor._oriRotator == null)
				{
					Cursor._oriRotator = new Rotator();
				}
				return Cursor._oriRotator;
			}
		}

		// Token: 0x17004D06 RID: 19718
		// (get) Token: 0x060257EA RID: 153578 RVA: 0x00A8F9E4 File Offset: 0x00A8DBE4
		private static Rotator TempRotator
		{
			get
			{
				if (Cursor._tempRotator == null)
				{
					Cursor._tempRotator = new Rotator();
				}
				return Cursor._tempRotator;
			}
		}

		// Token: 0x17004D07 RID: 19719
		// (get) Token: 0x060257EB RID: 153579 RVA: 0x00A8F9FC File Offset: 0x00A8DBFC
		private static Vector TempFollowLocation
		{
			get
			{
				if (Cursor._tempFollowLocation == null)
				{
					Cursor._tempFollowLocation = new Vector();
				}
				return Cursor._tempFollowLocation;
			}
		}

		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x060257EC RID: 153580 RVA: 0x00A8FA14 File Offset: 0x00A8DC14
		private static Vector TempThirdLocation
		{
			get
			{
				if (Cursor._tempThirdLocation == null)
				{
					Cursor._tempThirdLocation = new Vector();
				}
				return Cursor._tempThirdLocation;
			}
		}

		// Token: 0x060257ED RID: 153581 RVA: 0x00A8FA2C File Offset: 0x00A8DC2C
		private void CreateOriginalItem()
		{
			if (this.OriginalParentItem != null && this.OriginalParentItem.IsValid())
			{
				return;
			}
			if (this.AsyncLoadId == LguiResourceManager.Instance.InvalidId)
			{
				this.AsyncLoadId = LguiResourceManager.Instance.LoadPrefabByResourceId("UiItem_Cursor_Prefab", UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pool), delegate([Nullable(2)] AActor actor, string assetPath, ELguiLoadResultType loadResultType)
				{
					this.AsyncLoadId = LguiResourceManager.Instance.InvalidId;
					LguiUtil.Instance.SetActorIsPermanent(actor, true, true);
					this.OriginalParentItem = (actor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
					this.OriginalItem = this.OriginalParentItem.UIChildren.Get(0);
					this.OriginalItem.SetUIActive(false);
				}, "Ui.CommonUi");
			}
		}

		// Token: 0x060257EE RID: 153582 RVA: 0x00A8FA98 File Offset: 0x00A8DC98
		protected void RefreshUseItem()
		{
			if (this.UseItem != null && this.UseItem.IsValid())
			{
				return;
			}
			this.CreateOriginalItem();
			if (this.OriginalParentItem == null || !this.OriginalParentItem.IsValid())
			{
				return;
			}
			if (this.OriginalItem == null || !this.OriginalItem.IsValid())
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "光标原始节点出现问题", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UseItem = LguiUtil.Instance.CopyItem(this.OriginalItem, this.OriginalParentItem);
			LguiUtil.Instance.SetActorIsPermanent(this.UseItem.GetOwner(), true, true);
			this.IsInFloat = false;
			this.UpdateCursorItemAttachParent();
			this.IsUseItemActive = this.UseItem.IsUIActiveSelf();
			bool value = this.FollowItem != null;
			this.TrySetUseItemUiActive(value);
			Cursor.TempLocation.Set(0.0, 0.0, 0.0);
			Cursor.TempRotator.Set(0f, 0f, 0f);
			FRotator frotator = this.UseItem.GetOwner().K2_GetActorRotation();
			Cursor.OriRotator.Set(frotator.Pitch, frotator.Yaw, frotator.Roll);
		}

		// Token: 0x060257EF RID: 153583 RVA: 0x00A8FBDC File Offset: 0x00A8DDDC
		private void SetUseItemMoveInstantly()
		{
			if (this.UseItem == null || this.FollowItem == null)
			{
				return;
			}
			FVectorDouble fvectorDouble = this.FollowItem.D_K2_GetComponentLocation();
			FVector fvector = fvectorDouble;
			fvectorDouble = this.FollowItem.D_K2_GetComponentScale();
			FVector fvector2 = fvectorDouble;
			Cursor.TempFollowLocation.Set((double)(fvector.X + Cursor.TempOffsetX * fvector2.X), 0.0, (double)(fvector.Z + Cursor.TempOffsetY * fvector2.Y));
			Cursor.TempThirdLocation.DeepCopy(Cursor.TempFollowLocation);
			Cursor.TempLocation.DeepCopy(Cursor.TempFollowLocation);
			Cursor.TempRotator.DeepCopy(Cursor.OriRotator);
			Cursor.TempRotator.Pitch += (float)this.TempRotation;
			this.AppliedRotation = this.TempRotation;
			this.RotationTransitionRemaining = 0f;
			FHitResult fhitResult = new FHitResult();
			this.UseItem.GetOwner().D_K2_SetActorLocationAndRotation(Cursor.TempFollowLocation.ToUeVector(false), Cursor.TempRotator.ToUeRotator(), false, ref fhitResult, false);
		}

		// Token: 0x060257F0 RID: 153584 RVA: 0x00A8FCEC File Offset: 0x00A8DEEC
		private void UpdateCursorItemAttachParent()
		{
			if (this.UseItem == null)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.VideoView) || UiManager.Instance.IsViewOpen(EUiViewName.NetWorkConfirmBoxView) || UiManager.Instance.IsViewOpen(EUiViewName.SubPackageDownLoadView) || UiManager.Instance.IsViewOpen(EUiViewName.SubPackageDownLoadFreeSpaceTipsView) || UiManager.Instance.IsViewOpen(EUiViewName.SubPackageDownLoadMobileClearPopView))
			{
				if (this.IsInFloat)
				{
					this.UseItem.SetUIParent(UiLayer.Instance.GetLayerRootUiItem(ELayerType.Mask), false);
					this.IsInFloat = false;
					return;
				}
			}
			else if (!this.IsInFloat)
			{
				this.UseItem.SetUIParent(UiLayer.Instance.GetLayerRootUiItem(ELayerType.Float), false);
				this.IsInFloat = true;
			}
		}

		// Token: 0x060257F1 RID: 153585 RVA: 0x00A8FDAC File Offset: 0x00A8DFAC
		public void SetFollowItem(TsUiNavigationBehaviorListener listener)
		{
			this.Listener = listener;
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (listener != null) ? new TWeakObjectPtr<UUIItem>?(listener.RootUIComp) : null;
			this.FollowItem = ((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null);
			this.TotalSpeed = 0f;
			this.MoveTickTime = 0f;
			Cursor.TempWidth = 0f;
			Cursor.TempHeight = 0f;
			if (listener == null)
			{
				this.TrySetUseItemUiActive(false);
			}
			else
			{
				this.IsNeedMove = true;
				this.IsCursorOpen = listener.Cursor.Switch;
				this.CacheFollowOffsetValue();
				this.TrySetUseItemUiActive(true);
				this.HandleMoveInstantly();
			}
			this.UpdateCursorItemAttachParent();
		}

		// Token: 0x060257F2 RID: 153586 RVA: 0x00A8FE5F File Offset: 0x00A8E05F
		public void RepeatMove()
		{
			this.IsNeedMove = true;
			this.MoveTickTime = 0f;
		}

		// Token: 0x060257F3 RID: 153587 RVA: 0x00A8FE74 File Offset: 0x00A8E074
		private void CacheFollowOffsetValue()
		{
			float width = this.FollowItem.GetWidth();
			float height = this.FollowItem.GetHeight();
			int cursorRotation = this.Listener.GetCursorRotation();
			if (Cursor.TempWidth == width && Cursor.TempHeight == height && this.TempRotation == cursorRotation)
			{
				return;
			}
			FVector2D fvector2D = this.FollowItem.GetPivot();
			FVector fvector = fvector2D;
			fvector2D = this.Listener.GetCursorOffset();
			FVector fvector2 = fvector2D;
			fvector2D = this.Listener.GetBoundOffset();
			FVector fvector3 = fvector2D;
			float num = fvector2.X - MathUtils.Instance.Clamp(fvector.X, 0f, 1f);
			float num2 = fvector2.Y - MathUtils.Instance.Clamp(fvector.Y, 0f, 1f);
			Cursor.TempOffsetX = num * width + fvector3.X;
			Cursor.TempOffsetY = num2 * height + fvector3.Y;
			this.TempRotation = cursorRotation;
			Cursor.TempWidth = width;
			Cursor.TempHeight = height;
		}

		// Token: 0x060257F4 RID: 153588 RVA: 0x00A8FF74 File Offset: 0x00A8E174
		private void UpdateCursorAlpha()
		{
			if (this.IsUseItemActive)
			{
				this.UseItem.SetAlpha(this.FollowItem.GetCalculatedParentAlpha());
			}
		}

		// Token: 0x060257F5 RID: 153589 RVA: 0x00A8FF94 File Offset: 0x00A8E194
		public void SetIsUseMouse(bool value)
		{
			if (this.IsUseMouse == value)
			{
				return;
			}
			this.IsUseMouse = value;
			UUIItem followItem = this.FollowItem;
			bool value2 = followItem != null && followItem.bIsUIActive;
			this.TrySetUseItemUiActive(value2);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[InputChange]使用鼠标标记发生变更!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("使用鼠标", value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060257F6 RID: 153590 RVA: 0x00A8FFFB File Offset: 0x00A8E1FB
		private void HandleMoveInstantly()
		{
			if (this.IsMoveInstantly)
			{
				this.IsMoveInstantly = false;
				this.SetUseItemMoveInstantly();
				this.UpdateCursorAlpha();
			}
		}

		// Token: 0x060257F7 RID: 153591 RVA: 0x00A90018 File Offset: 0x00A8E218
		private bool CheckMoveCondition()
		{
			if (!UiManager.Instance.IsInited)
			{
				return false;
			}
			this.RefreshUseItem();
			if (this.OriginalParentItem == null)
			{
				return false;
			}
			if (this.FollowItem == null || !this.FollowItem.IsValid())
			{
				return false;
			}
			if (this.Listener == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "光标, 找不到导航对象", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return this.IsNeedMove;
		}

		// Token: 0x060257F8 RID: 153592 RVA: 0x00A90090 File Offset: 0x00A8E290
		private void HandleMove(float delta)
		{
			FVectorDouble fvectorDouble = this.FollowItem.D_K2_GetComponentLocation();
			FVector fvector = fvectorDouble;
			fvectorDouble = this.FollowItem.D_K2_GetComponentScale();
			FVector fvector2 = fvectorDouble;
			Cursor.TempFollowLocation.Set((double)(fvector.X + Cursor.TempOffsetX * fvector2.X), 0.0, (double)(fvector.Z + Cursor.TempOffsetY * fvector2.Y));
			Vector.Lerp(Cursor.TempLocation, Cursor.TempFollowLocation, (double)this.TotalSpeed, Cursor.TempThirdLocation);
			this.TotalSpeed += 0.05f;
			if (Vector.PointsAreSame(Cursor.TempThirdLocation, Cursor.TempFollowLocation))
			{
				Cursor.TempThirdLocation.DeepCopy(Cursor.TempFollowLocation);
				this.SetMoveTickTime();
			}
			Cursor.TempLocation.DeepCopy(Cursor.TempThirdLocation);
			this.CacheFollowOffsetValue();
			FHitResult fhitResult = new FHitResult();
			AActor owner = this.UseItem.GetOwner();
			owner.D_K2_SetActorLocation(Cursor.TempThirdLocation.ToUeVector(false), false, ref fhitResult, false);
			this.HandleRotationTransition(delta, owner);
		}

		// Token: 0x060257F9 RID: 153593 RVA: 0x00A9019C File Offset: 0x00A8E39C
		private void HandleRotationTransition(float delta, AActor useItemOwner)
		{
			int tempRotation = this.TempRotation;
			float calculatedParentAlpha = this.FollowItem.GetCalculatedParentAlpha();
			if (this.RotationTransitionRemaining == 0f)
			{
				if (Math.Abs(tempRotation - this.AppliedRotation) <= 1)
				{
					this.UpdateCursorAlpha();
					return;
				}
				this.RotationTransitionRemaining = 0.2f;
			}
			this.RotationTransitionRemaining -= delta / (float)TimeUtil.Instance.InverseMillisecond;
			float num = 0.1f;
			if (this.RotationTransitionRemaining > num)
			{
				float num2 = (num * 2f - this.RotationTransitionRemaining) / num;
				this.UseItem.SetAlpha(calculatedParentAlpha * (1f - num2));
				return;
			}
			if (Math.Abs(tempRotation - this.AppliedRotation) > 1)
			{
				this.AppliedRotation = tempRotation;
				Cursor.TempRotator.DeepCopy(Cursor.OriRotator);
				Cursor.TempRotator.Pitch += (float)tempRotation;
				useItemOwner.K2_SetActorRotation(Cursor.TempRotator.ToUeRotator(), false);
			}
			if (this.RotationTransitionRemaining > 0f)
			{
				float num3 = (num - this.RotationTransitionRemaining) / num;
				this.UseItem.SetAlpha(calculatedParentAlpha * num3);
				return;
			}
			this.UseItem.SetAlpha(calculatedParentAlpha);
			this.RotationTransitionRemaining = 0f;
		}

		// Token: 0x060257FA RID: 153594 RVA: 0x00A902C7 File Offset: 0x00A8E4C7
		public void Tick(float delta)
		{
			if (this.CheckMoveCondition())
			{
				this.HandleMove(delta);
				this.TickMoveTickTime(delta);
			}
		}

		// Token: 0x060257FB RID: 153595 RVA: 0x00A902E0 File Offset: 0x00A8E4E0
		public void Clear()
		{
			LguiResourceManager.Instance.CancelLoadPrefab(this.AsyncLoadId);
			if (this.OriginalParentItem != null && this.OriginalParentItem.IsValid())
			{
				ActorSystem.Instance.Put("Cursor.Clear1", this.OriginalParentItem.GetOwner(), null);
			}
			if (this.UseItem != null && this.UseItem.IsValid())
			{
				ActorSystem.Instance.Put("Cursor.Clear2", this.UseItem.GetOwner(), null);
			}
			this.RemoveCursorActiveHandle();
			this.AsyncLoadId = LguiResourceManager.Instance.InvalidId;
			this.CursorActiveDelayTime = 0f;
			this.OriginalParentItem = null;
			this.OriginalItem = null;
			this.UseItem = null;
			this.FollowItem = null;
			this.Listener = null;
			this.IsNeedMove = false;
			this.TotalSpeed = 0f;
			this.RotationTransitionRemaining = 0f;
			this.AppliedRotation = 0;
		}

		// Token: 0x060257FC RID: 153596 RVA: 0x00A903C7 File Offset: 0x00A8E5C7
		private void SetMoveTickTime()
		{
			if (this.MoveTickTime <= 0f)
			{
				this.MoveTickTime = 2000f;
			}
		}

		// Token: 0x060257FD RID: 153597 RVA: 0x00A903E1 File Offset: 0x00A8E5E1
		private void TickMoveTickTime(float delta)
		{
			if (this.MoveTickTime <= 0f)
			{
				return;
			}
			this.MoveTickTime -= delta;
			if (this.MoveTickTime <= 0f)
			{
				this.IsNeedMove = false;
			}
		}

		// Token: 0x060257FE RID: 153598 RVA: 0x00A90414 File Offset: 0x00A8E614
		public void TrySetUseItemUiActive(bool value)
		{
			if (this.UseItem == null)
			{
				return;
			}
			if (!this.UseItem.IsValid())
			{
				return;
			}
			bool flag = value && this.IsCursorOpen && !this.IsUseMouse;
			if (this.IsUseItemActive == flag)
			{
				return;
			}
			this.RemoveCursorActiveHandle();
			this.IsUseItemActive = flag;
			if (!flag)
			{
				this.SetUseItemUiActive(flag);
				return;
			}
			this.AddCursorActiveHandle();
		}

		// Token: 0x060257FF RID: 153599 RVA: 0x00A90478 File Offset: 0x00A8E678
		private void SetUseItemUiActive(bool active)
		{
			this.UseItem.SetUIActive(active);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[InputChange]鼠标显隐发生变更!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("active", this.IsUseItemActive);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06025800 RID: 153600 RVA: 0x00A904C8 File Offset: 0x00A8E6C8
		private void AddCursorActiveHandle()
		{
			if (this.CursorActiveDelayTime == 0f)
			{
				this.SetUseItemUiActive(true);
				return;
			}
			this.SetUseItemUiActive(false);
			this.CursorActiveHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float delta)
			{
				this.CursorActiveHandle = null;
				this.SetUseItemUiActive(true);
			}, this.CursorActiveDelayTime, null, null, true, 1f);
			this.CursorActiveDelayTime = 0f;
		}

		// Token: 0x06025801 RID: 153601 RVA: 0x00A90526 File Offset: 0x00A8E726
		private void RemoveCursorActiveHandle()
		{
			if (this.CursorActiveHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CursorActiveHandle);
				this.CursorActiveHandle = null;
			}
		}

		// Token: 0x06025802 RID: 153602 RVA: 0x00A90548 File Offset: 0x00A8E748
		public void SetCursorActiveDelayTime(float time)
		{
			this.CursorActiveDelayTime = time;
		}

		// Token: 0x06025803 RID: 153603 RVA: 0x00A90551 File Offset: 0x00A8E751
		public void RefreshCursorActive()
		{
			if (this.Listener == null)
			{
				return;
			}
			this.IsCursorOpen = this.Listener.Cursor.Switch;
			this.TrySetUseItemUiActive(true);
		}

		// Token: 0x06025804 RID: 153604 RVA: 0x00A90579 File Offset: 0x00A8E779
		public static void CreateStaticDefaultValue()
		{
			Cursor._tempLocation = Vector.Create();
			Cursor._tempFollowLocation = Vector.Create();
			Cursor._tempThirdLocation = Vector.Create();
		}

		// Token: 0x06025805 RID: 153605 RVA: 0x00A9059C File Offset: 0x00A8E79C
		public static void ResetStaticDefaultValue()
		{
			Cursor.TempOffsetX = 0f;
			Cursor.TempOffsetY = 0f;
			Cursor.TempWidth = 0f;
			Cursor.TempHeight = 0f;
			Cursor._tempLocation = null;
			Cursor._tempFollowLocation = null;
			Cursor._tempThirdLocation = null;
			Cursor._tempRotator = null;
			Cursor._oriRotator = null;
		}

		// Token: 0x04014BA2 RID: 84898
		public const float SPEED = 0.05f;

		// Token: 0x04014BA3 RID: 84899
		public const float ALLOW_MOVE_TICK_LIMIT = 2000f;

		// Token: 0x04014BA4 RID: 84900
		[Nullable(2)]
		private UUIItem OriginalParentItem;

		// Token: 0x04014BA5 RID: 84901
		[Nullable(2)]
		private UUIItem OriginalItem;

		// Token: 0x04014BA6 RID: 84902
		[Nullable(2)]
		private UUIItem UseItem;

		// Token: 0x04014BA7 RID: 84903
		[Nullable(2)]
		private UUIItem FollowItem;

		// Token: 0x04014BA8 RID: 84904
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;

		// Token: 0x04014BA9 RID: 84905
		private int AsyncLoadId = LguiResourceManager.Instance.InvalidId;

		// Token: 0x04014BAA RID: 84906
		private float TotalSpeed;

		// Token: 0x04014BAB RID: 84907
		private bool IsNeedMove;

		// Token: 0x04014BAC RID: 84908
		private bool IsCursorOpen = true;

		// Token: 0x04014BAD RID: 84909
		private bool IsUseMouse;

		// Token: 0x04014BAE RID: 84910
		private bool IsInFloat;

		// Token: 0x04014BAF RID: 84911
		private float RotationTransitionRemaining;

		// Token: 0x04014BB0 RID: 84912
		private int AppliedRotation;

		// Token: 0x04014BB1 RID: 84913
		public bool IsMoveInstantly;

		// Token: 0x04014BB2 RID: 84914
		[Nullable(2)]
		private static Vector _tempLocation;

		// Token: 0x04014BB3 RID: 84915
		[Nullable(2)]
		private static Rotator _oriRotator;

		// Token: 0x04014BB4 RID: 84916
		[Nullable(2)]
		private static Rotator _tempRotator;

		// Token: 0x04014BB5 RID: 84917
		[Nullable(2)]
		private static Vector _tempFollowLocation;

		// Token: 0x04014BB6 RID: 84918
		private static float TempOffsetX;

		// Token: 0x04014BB7 RID: 84919
		private static float TempOffsetY;

		// Token: 0x04014BB8 RID: 84920
		private int TempRotation;

		// Token: 0x04014BB9 RID: 84921
		[Nullable(2)]
		private static Vector _tempThirdLocation;

		// Token: 0x04014BBA RID: 84922
		private static float TempWidth;

		// Token: 0x04014BBB RID: 84923
		private static float TempHeight;

		// Token: 0x04014BBC RID: 84924
		private float MoveTickTime;

		// Token: 0x04014BBD RID: 84925
		[Nullable(2)]
		private TimerHandle CursorActiveHandle;

		// Token: 0x04014BBE RID: 84926
		private bool IsUseItemActive;

		// Token: 0x04014BBF RID: 84927
		private float CursorActiveDelayTime;
	}
}
