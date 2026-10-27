using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048E6 RID: 18662
	[NullableContext(1)]
	[Nullable(0)]
	public class Cursor : IStaticVariableResetter
	{
		// Token: 0x06030CBA RID: 199866 RVA: 0x00B54B25 File Offset: 0x00B52D25
		static Cursor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Cursor.CreateStaticDefaultValue), new Action(Cursor.ResetStaticDefaultValue));
		}

		// Token: 0x1700799C RID: 31132
		// (get) Token: 0x06030CBB RID: 199867 RVA: 0x00B54B44 File Offset: 0x00B52D44
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

		// Token: 0x1700799D RID: 31133
		// (get) Token: 0x06030CBC RID: 199868 RVA: 0x00B54B5C File Offset: 0x00B52D5C
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

		// Token: 0x1700799E RID: 31134
		// (get) Token: 0x06030CBD RID: 199869 RVA: 0x00B54B74 File Offset: 0x00B52D74
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

		// Token: 0x1700799F RID: 31135
		// (get) Token: 0x06030CBE RID: 199870 RVA: 0x00B54B8C File Offset: 0x00B52D8C
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

		// Token: 0x170079A0 RID: 31136
		// (get) Token: 0x06030CBF RID: 199871 RVA: 0x00B54BA4 File Offset: 0x00B52DA4
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

		// Token: 0x06030CC0 RID: 199872 RVA: 0x00B54BBC File Offset: 0x00B52DBC
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

		// Token: 0x06030CC1 RID: 199873 RVA: 0x00B54C28 File Offset: 0x00B52E28
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

		// Token: 0x06030CC2 RID: 199874 RVA: 0x00B54D6C File Offset: 0x00B52F6C
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

		// Token: 0x06030CC3 RID: 199875 RVA: 0x00B54E7C File Offset: 0x00B5307C
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

		// Token: 0x06030CC4 RID: 199876 RVA: 0x00B54F3C File Offset: 0x00B5313C
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

		// Token: 0x06030CC5 RID: 199877 RVA: 0x00B54FEF File Offset: 0x00B531EF
		public void RepeatMove()
		{
			this.IsNeedMove = true;
			this.MoveTickTime = 0f;
		}

		// Token: 0x06030CC6 RID: 199878 RVA: 0x00B55004 File Offset: 0x00B53204
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

		// Token: 0x06030CC7 RID: 199879 RVA: 0x00B55104 File Offset: 0x00B53304
		private void UpdateCursorAlpha()
		{
			if (this.IsUseItemActive)
			{
				this.UseItem.SetAlpha(this.FollowItem.GetCalculatedParentAlpha());
			}
		}

		// Token: 0x06030CC8 RID: 199880 RVA: 0x00B55124 File Offset: 0x00B53324
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

		// Token: 0x06030CC9 RID: 199881 RVA: 0x00B5518B File Offset: 0x00B5338B
		private void HandleMoveInstantly()
		{
			if (this.IsMoveInstantly)
			{
				this.IsMoveInstantly = false;
				this.SetUseItemMoveInstantly();
				this.UpdateCursorAlpha();
			}
		}

		// Token: 0x06030CCA RID: 199882 RVA: 0x00B551A8 File Offset: 0x00B533A8
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

		// Token: 0x06030CCB RID: 199883 RVA: 0x00B55220 File Offset: 0x00B53420
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

		// Token: 0x06030CCC RID: 199884 RVA: 0x00B5532C File Offset: 0x00B5352C
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

		// Token: 0x06030CCD RID: 199885 RVA: 0x00B55457 File Offset: 0x00B53657
		public void Tick(float delta)
		{
			if (this.CheckMoveCondition())
			{
				this.HandleMove(delta);
				this.TickMoveTickTime(delta);
			}
		}

		// Token: 0x06030CCE RID: 199886 RVA: 0x00B55470 File Offset: 0x00B53670
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

		// Token: 0x06030CCF RID: 199887 RVA: 0x00B55557 File Offset: 0x00B53757
		private void SetMoveTickTime()
		{
			if (this.MoveTickTime <= 0f)
			{
				this.MoveTickTime = 2000f;
			}
		}

		// Token: 0x06030CD0 RID: 199888 RVA: 0x00B55571 File Offset: 0x00B53771
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

		// Token: 0x06030CD1 RID: 199889 RVA: 0x00B555A4 File Offset: 0x00B537A4
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

		// Token: 0x06030CD2 RID: 199890 RVA: 0x00B55608 File Offset: 0x00B53808
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

		// Token: 0x06030CD3 RID: 199891 RVA: 0x00B55658 File Offset: 0x00B53858
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

		// Token: 0x06030CD4 RID: 199892 RVA: 0x00B556B6 File Offset: 0x00B538B6
		private void RemoveCursorActiveHandle()
		{
			if (this.CursorActiveHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CursorActiveHandle);
				this.CursorActiveHandle = null;
			}
		}

		// Token: 0x06030CD5 RID: 199893 RVA: 0x00B556D8 File Offset: 0x00B538D8
		public void SetCursorActiveDelayTime(float time)
		{
			this.CursorActiveDelayTime = time;
		}

		// Token: 0x06030CD6 RID: 199894 RVA: 0x00B556E1 File Offset: 0x00B538E1
		public void RefreshCursorActive()
		{
			if (this.Listener == null)
			{
				return;
			}
			this.IsCursorOpen = this.Listener.Cursor.Switch;
			this.TrySetUseItemUiActive(true);
		}

		// Token: 0x06030CD7 RID: 199895 RVA: 0x00B55709 File Offset: 0x00B53909
		public static void CreateStaticDefaultValue()
		{
			Cursor._tempLocation = Vector.Create();
			Cursor._tempFollowLocation = Vector.Create();
			Cursor._tempThirdLocation = Vector.Create();
		}

		// Token: 0x06030CD8 RID: 199896 RVA: 0x00B5572C File Offset: 0x00B5392C
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

		// Token: 0x0401A32F RID: 107311
		public const float SPEED = 0.05f;

		// Token: 0x0401A330 RID: 107312
		public const float ALLOW_MOVE_TICK_LIMIT = 2000f;

		// Token: 0x0401A331 RID: 107313
		[Nullable(2)]
		private UUIItem OriginalParentItem;

		// Token: 0x0401A332 RID: 107314
		[Nullable(2)]
		private UUIItem OriginalItem;

		// Token: 0x0401A333 RID: 107315
		[Nullable(2)]
		private UUIItem UseItem;

		// Token: 0x0401A334 RID: 107316
		[Nullable(2)]
		private UUIItem FollowItem;

		// Token: 0x0401A335 RID: 107317
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;

		// Token: 0x0401A336 RID: 107318
		private int AsyncLoadId = LguiResourceManager.Instance.InvalidId;

		// Token: 0x0401A337 RID: 107319
		private float TotalSpeed;

		// Token: 0x0401A338 RID: 107320
		private bool IsNeedMove;

		// Token: 0x0401A339 RID: 107321
		private bool IsCursorOpen = true;

		// Token: 0x0401A33A RID: 107322
		private bool IsUseMouse;

		// Token: 0x0401A33B RID: 107323
		private bool IsInFloat;

		// Token: 0x0401A33C RID: 107324
		private float RotationTransitionRemaining;

		// Token: 0x0401A33D RID: 107325
		private int AppliedRotation;

		// Token: 0x0401A33E RID: 107326
		public bool IsMoveInstantly;

		// Token: 0x0401A33F RID: 107327
		[Nullable(2)]
		private static Vector _tempLocation;

		// Token: 0x0401A340 RID: 107328
		[Nullable(2)]
		private static Rotator _oriRotator;

		// Token: 0x0401A341 RID: 107329
		[Nullable(2)]
		private static Rotator _tempRotator;

		// Token: 0x0401A342 RID: 107330
		[Nullable(2)]
		private static Vector _tempFollowLocation;

		// Token: 0x0401A343 RID: 107331
		private static float TempOffsetX;

		// Token: 0x0401A344 RID: 107332
		private static float TempOffsetY;

		// Token: 0x0401A345 RID: 107333
		private int TempRotation;

		// Token: 0x0401A346 RID: 107334
		[Nullable(2)]
		private static Vector _tempThirdLocation;

		// Token: 0x0401A347 RID: 107335
		private static float TempWidth;

		// Token: 0x0401A348 RID: 107336
		private static float TempHeight;

		// Token: 0x0401A349 RID: 107337
		private float MoveTickTime;

		// Token: 0x0401A34A RID: 107338
		[Nullable(2)]
		private TimerHandle CursorActiveHandle;

		// Token: 0x0401A34B RID: 107339
		private bool IsUseItemActive;

		// Token: 0x0401A34C RID: 107340
		private float CursorActiveDelayTime;
	}
}
