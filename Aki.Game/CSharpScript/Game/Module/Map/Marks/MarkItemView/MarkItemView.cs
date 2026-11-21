using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Container;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044EA RID: 17642
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkItemView : MarkPanelBase
	{
		// Token: 0x0602C8B1 RID: 182449 RVA: 0x00C81E3C File Offset: 0x00C8003C
		public MarkItemView(MarkItem holder)
		{
		}

		// Token: 0x17005939 RID: 22841
		// (get) Token: 0x0602C8B2 RID: 182450 RVA: 0x00C81E5D File Offset: 0x00C8005D
		protected MarkItemTopRightIconHandle MarkItemTopRightIconHandle
		{
			get
			{
				return this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.TopRightIcon) as MarkItemTopRightIconHandle;
			}
		}

		// Token: 0x1700593A RID: 22842
		// (get) Token: 0x0602C8B3 RID: 182451 RVA: 0x00C81E70 File Offset: 0x00C80070
		protected IMarkItemHandle MarkItemRangeHandle
		{
			get
			{
				return this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Range);
			}
		}

		// Token: 0x1700593B RID: 22843
		// (get) Token: 0x0602C8B4 RID: 182452 RVA: 0x00C81E7E File Offset: 0x00C8007E
		protected MarkItemNameHandle MarkItemNameHandle
		{
			get
			{
				return (MarkItemNameHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Name);
			}
		}

		// Token: 0x1700593C RID: 22844
		// (get) Token: 0x0602C8B5 RID: 182453 RVA: 0x00C81E91 File Offset: 0x00C80091
		protected MarkItemOutOfBoundHandle MarkItemOutOfBoundHandle
		{
			get
			{
				return (MarkItemOutOfBoundHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.OutOfBound);
			}
		}

		// Token: 0x1700593D RID: 22845
		// (get) Token: 0x0602C8B6 RID: 182454 RVA: 0x00C81EA4 File Offset: 0x00C800A4
		protected MarkItemSelectHandle MarkItemSelectHandle
		{
			get
			{
				return (MarkItemSelectHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Select);
			}
		}

		// Token: 0x1700593E RID: 22846
		// (get) Token: 0x0602C8B7 RID: 182455 RVA: 0x00C81EB7 File Offset: 0x00C800B7
		protected MarkItemTrackHandle MarkItemTrackHandle
		{
			get
			{
				return (MarkItemTrackHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Track);
			}
		}

		// Token: 0x1700593F RID: 22847
		// (get) Token: 0x0602C8B8 RID: 182456 RVA: 0x00C81ECA File Offset: 0x00C800CA
		protected MarkItemChildIconHandle MarkItemChildIconHandle
		{
			get
			{
				return (MarkItemChildIconHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.ChildIcon);
			}
		}

		// Token: 0x17005940 RID: 22848
		// (get) Token: 0x0602C8B9 RID: 182457 RVA: 0x00C81EDD File Offset: 0x00C800DD
		protected MarkItemVerticalPointerHandle MarkItemVerticalPointerHandle
		{
			get
			{
				return (MarkItemVerticalPointerHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.VerticalPointer);
			}
		}

		// Token: 0x17005941 RID: 22849
		// (get) Token: 0x0602C8BA RID: 182458 RVA: 0x00C81EF0 File Offset: 0x00C800F0
		protected MarkItemGravityReverseIconHandle MarkItemGravityReverseIconHandle
		{
			get
			{
				return (MarkItemGravityReverseIconHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.GravityReverse);
			}
		}

		// Token: 0x17005942 RID: 22850
		// (get) Token: 0x0602C8BB RID: 182459 RVA: 0x00C81F04 File Offset: 0x00C80104
		protected MarkItemAutoPilotTrackHandle MarkItemAutoPilotTrackHandle
		{
			get
			{
				return (MarkItemAutoPilotTrackHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.AutoPilotTrack);
			}
		}

		// Token: 0x17005943 RID: 22851
		// (get) Token: 0x0602C8BC RID: 182460 RVA: 0x00C81F18 File Offset: 0x00C80118
		public bool IsSelected
		{
			get
			{
				return this.Holder.IsSelected;
			}
		}

		// Token: 0x0602C8BD RID: 182461 RVA: 0x00C81F25 File Offset: 0x00C80125
		public void NotifySelectedChanged(bool newState)
		{
			this.OnSelectedStateChange(newState);
		}

		// Token: 0x17005944 RID: 22852
		// (get) Token: 0x0602C8BE RID: 182462 RVA: 0x00C81F2E File Offset: 0x00C8012E
		// (set) Token: 0x0602C8BF RID: 182463 RVA: 0x00C81F36 File Offset: 0x00C80136
		public bool ViewInitialized { get; private set; }

		// Token: 0x0602C8C0 RID: 182464 RVA: 0x00C81F3F File Offset: 0x00C8013F
		protected virtual void OnSelectedStateChange(bool newState)
		{
		}

		// Token: 0x0602C8C1 RID: 182465 RVA: 0x00C81F44 File Offset: 0x00C80144
		public UniTask InitializeMarkItemViewNewAsync(Action createCb)
		{
			MarkItemView.<InitializeMarkItemViewNewAsync>d__40 <InitializeMarkItemViewNewAsync>d__;
			<InitializeMarkItemViewNewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeMarkItemViewNewAsync>d__.<>4__this = this;
			<InitializeMarkItemViewNewAsync>d__.createCb = createCb;
			<InitializeMarkItemViewNewAsync>d__.<>1__state = -1;
			<InitializeMarkItemViewNewAsync>d__.<>t__builder.Start<MarkItemView.<InitializeMarkItemViewNewAsync>d__40>(ref <InitializeMarkItemViewNewAsync>d__);
			return <InitializeMarkItemViewNewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C8C2 RID: 182466 RVA: 0x00C81F8F File Offset: 0x00C8018F
		public void InitializeData(MarkItem holder)
		{
			this.Holder = holder;
			this.OnDataInitialized(this.Holder);
		}

		// Token: 0x0602C8C3 RID: 182467 RVA: 0x00C81FA4 File Offset: 0x00C801A4
		public unsafe void InitializeView()
		{
			if (this.ViewInitialized)
			{
				return;
			}
			this.ViewInitialized = true;
			base.GetSprite(2).SetUIActive(false);
			base.GetSprite(1).SetUIActive(false);
			this.RefreshActorLabel();
			this.RefreshParentSocketTransform();
			this.ResetScale();
			this.InitComponentHandles();
			this.ApplyRootAnchorOffset();
			this.OnViewInitialize();
			if (this.Holder.MapType == EMapType.WorldMap)
			{
				UUISprite sprite = base.GetSprite(4);
				object key = this.Holder.MarkId;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "MapMarkSprite";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MarkId", this.Holder.MarkId);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "className";
				object item2;
				if (sprite == null)
				{
					item2 = null;
				}
				else
				{
					ULGUISpriteData_BaseObject sprite2 = sprite.GetSprite();
					item2 = ((sprite2 != null) ? sprite2.GetClass().GetName() : null);
				}
				ptr = new ValueTuple<string, object>(item, item2);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item3 = "GetAtlasTexture";
				object item4;
				if (sprite == null)
				{
					item4 = null;
				}
				else
				{
					ULGUISpriteData_BaseObject sprite3 = sprite.sprite;
					item4 = ((sprite3 != null) ? sprite3.GetAtlasTexture() : null);
				}
				ptr2 = new ValueTuple<string, object>(item3, item4);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("bNotUseDynamicSpriteAtlas", (sprite != null) ? new bool?(sprite.bNotUseDynamicSpriteAtlas) : null);
				MapLogger.InfoOnce(key, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}

		// Token: 0x0602C8C4 RID: 182468 RVA: 0x00C82108 File Offset: 0x00C80308
		public void RefreshView()
		{
			this.IsShowIcon = true;
			this.RefreshActorLabel();
			this.ApplyRootAnchorOffset();
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			this.MarkComponentContext.MarkItem = this.Holder;
			this.MarkComponentContext.MarkParentItem = this.RootItem.GetParentAsUIItem();
			this.MarkComponentContext.MarkRootItem = this.RootItem;
			this.ResetComponentHandlesVisibleState();
			this.ResetScale();
			this.ResetIcon();
			this.OnViewRefresh();
			base.DoRegisterEvents();
		}

		// Token: 0x0602C8C5 RID: 182469 RVA: 0x00C82195 File Offset: 0x00C80395
		public void RecycleView(bool? recycleToPoolImmediately)
		{
			base.DoUnRegisterEvents();
			this.OnViewRecycle();
			if (recycleToPoolImmediately.GetValueOrDefault())
			{
				this.RecycleToPool();
				return;
			}
			base.SetVisible(false);
			MarkSpritePool.UnRef(this.ComponentId);
			this.OnRecycle();
		}

		// Token: 0x0602C8C6 RID: 182470 RVA: 0x00C821CB File Offset: 0x00C803CB
		public override void RecycleToPool()
		{
			this.DestroyView();
			base.RecycleToPool();
		}

		// Token: 0x0602C8C7 RID: 182471 RVA: 0x00C821D9 File Offset: 0x00C803D9
		public void DestroyView()
		{
			this.DisposeComponentHandles();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			EventSystem.Instance.Emit<MarkItemView>(EEventName.OnMarkItemViewDestroy, this);
			this.ClearData();
		}

		// Token: 0x0602C8C8 RID: 182472 RVA: 0x00C82210 File Offset: 0x00C80410
		public void ClearData()
		{
			this.AttachParentSocketTransform = null;
			this.Holder = null;
		}

		// Token: 0x0602C8C9 RID: 182473 RVA: 0x00C82225 File Offset: 0x00C80425
		protected virtual void OnDataInitialized(MarkItem holder)
		{
		}

		// Token: 0x0602C8CA RID: 182474 RVA: 0x00C82227 File Offset: 0x00C80427
		protected virtual void OnViewInitialize()
		{
		}

		// Token: 0x0602C8CB RID: 182475 RVA: 0x00C82229 File Offset: 0x00C80429
		protected virtual void OnViewRefresh()
		{
		}

		// Token: 0x0602C8CC RID: 182476 RVA: 0x00C8222B File Offset: 0x00C8042B
		protected virtual void OnViewRecycle()
		{
		}

		// Token: 0x0602C8CD RID: 182477 RVA: 0x00C8222D File Offset: 0x00C8042D
		public virtual void RefreshGamePlayStateView()
		{
		}

		// Token: 0x0602C8CE RID: 182478 RVA: 0x00C8222F File Offset: 0x00C8042F
		[NullableContext(2)]
		public virtual UUIItem GetIconItem()
		{
			return base.GetSprite(1);
		}

		// Token: 0x0602C8CF RID: 182479 RVA: 0x00C82238 File Offset: 0x00C80438
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602C8D0 RID: 182480 RVA: 0x00C82304 File Offset: 0x00C80504
		protected override void OnStart()
		{
			if (this.Holder == null)
			{
				return;
			}
			this.CreateComponentHandles();
			this.InitLevelSequencePlayer();
			EventSystem.Instance.Emit<MarkItemView>(EEventName.OnMarkItemViewCreate, this);
		}

		// Token: 0x0602C8D1 RID: 182481 RVA: 0x00C8232C File Offset: 0x00C8052C
		protected override void OnBeforeDestroy()
		{
			this.DisposeComponentHandles();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			this.LoadingTaskCompletionSource = null;
			EventSystem.Instance.Emit<MarkItemView>(EEventName.OnMarkItemViewDestroy, this);
			this.AttachParentSocketTransform = null;
			this.Holder = null;
		}

		// Token: 0x0602C8D2 RID: 182482 RVA: 0x00C82382 File Offset: 0x00C80582
		protected void RefreshActorLabel()
		{
		}

		// Token: 0x0602C8D3 RID: 182483 RVA: 0x00C82384 File Offset: 0x00C80584
		protected void RefreshParentSocketTransform()
		{
			FName attachSocketName = this.RootItem.GetAttachSocketName();
			USceneComponent attachParent = this.RootItem.GetAttachParent();
			this.AttachParentSocketTransform = new FTransformDouble?(attachParent.D_GetSocketTransform(attachSocketName, ERelativeTransformSpace.RTS_World));
		}

		// Token: 0x0602C8D4 RID: 182484 RVA: 0x00C823BC File Offset: 0x00C805BC
		protected void InitLevelSequencePlayer()
		{
			if (this.LevelSequencePlayer != null)
			{
				return;
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnLevelSequenceStart));
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnLevelSequenceStop), false);
		}

		// Token: 0x0602C8D5 RID: 182485 RVA: 0x00C82414 File Offset: 0x00C80614
		public virtual void SetScale(float scale)
		{
			if (!this.IsHolderValid())
			{
				return;
			}
			bool flag = this.Holder.MapType == EMapType.MiniMap;
			float num = flag ? 1f : WorldMapModel.Instance.MapScale;
			float num2 = 1f / num;
			FVector fvector = flag ? this.AttachParentSocketTransform.Value.GetScale3D() : global::Vector.OneVector;
			float inX = scale * num2 / fvector.X;
			float inY = scale * num2 / fvector.Y;
			float inZ = scale * num2 / fvector.Z;
			FVector fvector2 = new FVector(inX, inY, inZ);
			this.RootItem.SetUIRelativeScale3D(fvector2);
		}

		// Token: 0x0602C8D6 RID: 182486 RVA: 0x00C824AF File Offset: 0x00C806AF
		protected bool IsHolderValid()
		{
			return this.Holder != null && this.AttachParentSocketTransform != null;
		}

		// Token: 0x17005945 RID: 22853
		// (get) Token: 0x0602C8D7 RID: 182487 RVA: 0x00C824CB File Offset: 0x00C806CB
		public bool IsViewReady
		{
			get
			{
				return (base.IsStart || base.IsShowOrShowing) && !base.IsDestroyOrDestroying && !base.IsHideOrHiding;
			}
		}

		// Token: 0x0602C8D8 RID: 182488 RVA: 0x00C824F0 File Offset: 0x00C806F0
		public void OnUpdate(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			if (this.Holder == null || base.IsRegister)
			{
				return;
			}
			this.IsScaleChangedLast = bIsScale;
			this.CheckPlayShowHideSequence();
			if (this.Holder.MapType == EMapType.WorldMap)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null && rootItem.bIsUIActive)
				{
					this.PlayAndSetScaleSelected(this.IsSelected);
				}
			}
			bool isCanShowView = this.Holder.IsCanShowView;
			if (!isCanShowView)
			{
				return;
			}
			if (isCanShowView)
			{
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 == null || !rootItem2.bIsUIActive)
				{
					base.SetUiActive(true);
				}
			}
			if (this.MarkComponentContext == null)
			{
				return;
			}
			this.UpdateComponents(playerLocation, bDragging);
			this.OnSafeUpdate(playerLocation, bDragging, bIsScale);
			this.OnLateUpdate();
			if (!isCanShowView && this.Holder.NeedPlayShowOrHideSeq == null)
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x0602C8D9 RID: 182489 RVA: 0x00C825B1 File Offset: 0x00C807B1
		public void ApplyOutOfBoundActive(bool active)
		{
			this.MarkItemOutOfBoundHandle.SetVisible(active);
			this.MarkItemOutOfBoundHandle.ApplyModified();
		}

		// Token: 0x0602C8DA RID: 182490 RVA: 0x00C825CC File Offset: 0x00C807CC
		private void UpdateComponents(global::Vector playerLocation, bool bDragging = false)
		{
			this.MarkItemTrackHandle.SetVisible(this.Holder.IsTracked && !bDragging);
			this.MarkItemSelectHandle.SetVisible(this.IsSelected);
			this.MarkItemVerticalPointerHandle.UpdateVerticalPointerType(this.Holder.WorldPosition, playerLocation);
			this.MarkItemAutoPilotTrackHandle.SetVisible(this.Holder.IsAutoPilotTracked);
			this.MarkItemGravityReverseIconHandle.SetVisible(this.Holder.ShowGravityReverseIcon);
			this.UpdateComponentHandles();
		}

		// Token: 0x0602C8DB RID: 182491 RVA: 0x00C82652 File Offset: 0x00C80852
		protected virtual void OnSafeUpdate(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
		}

		// Token: 0x0602C8DC RID: 182492 RVA: 0x00C82654 File Offset: 0x00C80854
		protected virtual void OnLateUpdate()
		{
			this.UpdateGravityIcon();
			this.ApplyComponentHandlesModified();
		}

		// Token: 0x0602C8DD RID: 182493 RVA: 0x00C82664 File Offset: 0x00C80864
		private void CheckPlayShowHideSequence()
		{
			if (this.Holder == null)
			{
				return;
			}
			if (this.IsScaleChangedLast)
			{
				if (this.Holder.NeedPlayShowOrHideSeq != null)
				{
					string needPlayShowOrHideSeq = this.Holder.NeedPlayShowOrHideSeq;
					if (!(needPlayShowOrHideSeq == "ShowView"))
					{
						if (needPlayShowOrHideSeq == "HideView")
						{
							this.PlayOutShowScaleRangeSequence();
						}
					}
					else
					{
						this.PlayInShowScaleRangeSequence();
					}
					this.Holder.NeedPlayShowOrHideSeq = null;
				}
			}
			else
			{
				this.Holder.NeedPlayShowOrHideSeq = null;
				this.Holder.OnLevelSequenceStop("HideView");
			}
			this.IsScaleChangedLast = false;
		}

		// Token: 0x0602C8DE RID: 182494 RVA: 0x00C826F6 File Offset: 0x00C808F6
		private void ResetIcon()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
			this.UpdateGravityIcon();
		}

		// Token: 0x0602C8DF RID: 182495 RVA: 0x00C82710 File Offset: 0x00C80910
		private void UpdateGravityIcon()
		{
			base.GetSprite(1).SetAlpha(WorldMapModel.Instance.IsMarkInGravityLayer(this.Holder.MarkId, this.Holder.Gravity) ? 1f : 0.4f);
		}

		// Token: 0x0602C8E0 RID: 182496 RVA: 0x00C8275C File Offset: 0x00C8095C
		public virtual void OnIconPathChanged(string iconPath)
		{
			UUISprite sprite = base.GetSprite(1);
			this.LoadIcon(sprite, iconPath);
		}

		// Token: 0x0602C8E1 RID: 182497 RVA: 0x00C8277C File Offset: 0x00C8097C
		protected void LoadIcon(UUISprite iconComponent, string iconPath)
		{
			if (!ObjectUtils.IsValid(iconComponent))
			{
				return;
			}
			if (!string.IsNullOrEmpty(iconPath))
			{
				this.SetSpriteByPath(iconPath, iconComponent, false, null, delegate(bool _)
				{
					if (iconComponent.IsValid())
					{
						iconComponent.SetUIActive(this.IsShowIcon);
					}
				});
				return;
			}
			iconComponent.SetUIActive(false);
		}

		// Token: 0x0602C8E2 RID: 182498 RVA: 0x00C827E3 File Offset: 0x00C809E3
		public virtual bool GetInteractiveFlag()
		{
			MarkItem holder = this.Holder;
			return holder != null && holder.IsCanShowView;
		}

		// Token: 0x0602C8E3 RID: 182499 RVA: 0x00C827F6 File Offset: 0x00C809F6
		protected virtual void OnLevelSequenceStart(string sequenceName)
		{
			MarkItem holder = this.Holder;
			if (holder == null)
			{
				return;
			}
			holder.OnLevelSequenceStart(sequenceName);
		}

		// Token: 0x0602C8E4 RID: 182500 RVA: 0x00C8280C File Offset: 0x00C80A0C
		protected virtual void OnLevelSequenceStop(string sequenceName)
		{
			MarkItem holder = this.Holder;
			if (holder != null)
			{
				holder.OnLevelSequenceStop(sequenceName);
			}
			if (sequenceName == "HideView")
			{
				bool showMarkView = this.Holder.ShowMarkView;
				base.SetUiActive(showMarkView);
				UUIItem item = base.GetItem(0);
				if (item == null)
				{
					return;
				}
				item.SetAlpha(1f);
			}
		}

		// Token: 0x0602C8E5 RID: 182501 RVA: 0x00C82864 File Offset: 0x00C80A64
		protected void PlayInShowScaleRangeSequence()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("ShowView", false, null, false);
		}

		// Token: 0x0602C8E6 RID: 182502 RVA: 0x00C8289C File Offset: 0x00C80A9C
		protected void PlayOutShowScaleRangeSequence()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("HideView", false, null, false);
		}

		// Token: 0x0602C8E7 RID: 182503 RVA: 0x00C828D1 File Offset: 0x00C80AD1
		public virtual UniTask PlayUnlockSequence()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602C8E8 RID: 182504 RVA: 0x00C828D8 File Offset: 0x00C80AD8
		private void PlayAndSetScaleSelected(bool selected)
		{
			if (this.MarkLogicSelected != selected)
			{
				this.MarkLogicSelected = selected;
				this.MarkSelectedTime = Time.Instance.NowSeconds;
				this.ClearTimer();
				this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), 50f, 1f, null, null, true);
				return;
			}
			if (this.IsOnScaleTween())
			{
				return;
			}
			float num = this.MarkLogicSelected ? ConfigCommonParamById.GetFloatConfig("MapMarkSelectedAdditionScale").Value : 0f;
			float scale = this.Holder.MarkScale + num;
			this.SetScale(scale);
		}

		// Token: 0x0602C8E9 RID: 182505 RVA: 0x00C82978 File Offset: 0x00C80B78
		private void OnTimerRefresh(float delta)
		{
			if (this.Holder == null)
			{
				this.ClearTimer();
				return;
			}
			float value = ConfigCommonParamById.GetFloatConfig("MapMarkSelectedAdditionScale").Value;
			float num = this.Holder.MarkScale + value;
			if (this.IsOnScaleTween())
			{
				double alpha = (Time.Instance.NowSeconds - this.MarkSelectedTime) / 0.20000000298023224;
				float num2 = this.MarkLogicSelected ? this.Holder.MarkScale : num;
				float num3 = this.MarkLogicSelected ? num : this.Holder.MarkScale;
				double num4 = MathUtils.Instance.Lerp((double)num2, (double)num3, alpha);
				this.SetScale((float)num4);
				return;
			}
			this.ClearTimer();
			this.PlayAndSetScaleSelected(this.MarkLogicSelected);
		}

		// Token: 0x0602C8EA RID: 182506 RVA: 0x00C82A38 File Offset: 0x00C80C38
		private bool IsOnScaleTween()
		{
			return this.MarkSelectedTime > 0.0 && this.MarkSelectedTime + 0.20000000298023224 >= Time.Instance.NowSeconds;
		}

		// Token: 0x0602C8EB RID: 182507 RVA: 0x00C82A6C File Offset: 0x00C80C6C
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x0602C8EC RID: 182508 RVA: 0x00C82A98 File Offset: 0x00C80C98
		public void OnRecycle()
		{
			this.RecycleHandles();
			this.LevelSequencePlayer.StopCurrentSequence(false, true);
			MarkSpritePool.UnRef(this.ComponentId);
			this.ClearTimer();
		}

		// Token: 0x0602C8ED RID: 182509 RVA: 0x00C82ABE File Offset: 0x00C80CBE
		protected void ApplyRootAnchorOffset()
		{
			this.RootItem.SetAnchorOffset(Vector2D.Create(this.Holder.InitUiPosition.X, this.Holder.InitUiPosition.Y).ToUeVector2D(false));
		}

		// Token: 0x0602C8EE RID: 182510 RVA: 0x00C82AF8 File Offset: 0x00C80CF8
		private void ResetScale()
		{
			this.SetScale(this.Holder.MarkScale);
			float configScale = this.Holder.ConfigScale;
			FVector uiitemScale = new FVector(configScale, configScale, configScale);
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIItemScale(uiitemScale);
			}
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 == null)
			{
				return;
			}
			FVectorDouble fvectorDouble = this.Holder.CornerScaleVector.ToUeVector(false);
			sprite2.SetUIItemScale(fvectorDouble);
		}

		// Token: 0x0602C8EF RID: 182511 RVA: 0x00C82B6C File Offset: 0x00C80D6C
		private void InitComponentHandles()
		{
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.Init();
			}
		}

		// Token: 0x0602C8F0 RID: 182512 RVA: 0x00C82BC4 File Offset: 0x00C80DC4
		protected virtual void CreateComponentHandles()
		{
			base.GetSprite(4).bNotUseDynamicSpriteAtlas = true;
			this.MarkComponentContext = new MarkItemComponentContext
			{
				TopRightIconSprite = base.GetSprite(4),
				SetSpriteByPathAction = new TSetSpriteByPathAction(this.SetSpriteByPath),
				MarkComponentContainer = base.GetItem(0),
				MarkParentItem = this.RootItem.GetParentAsUIItem(),
				MarkRootItem = this.RootItem,
				MarkItem = this.Holder
			};
			this.MarkItemComponentHandleMap[EMarkViewComponentType.TopRightIcon] = this.CreateTopRightHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.Range] = this.CreateRangeHandle<MarkRangeImageComponent>(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.Name] = this.CreateNameHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.OutOfBound] = this.CreateOutOfBoundHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.Select] = this.CreateSelectHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.Track] = this.CreateTrackHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.ChildIcon] = this.CreateChildIconHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.VerticalPointer] = this.CreateVerticalPointerHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.GravityReverse] = this.CreateGravityReverseIconHandle(this.MarkComponentContext);
			this.MarkItemComponentHandleMap[EMarkViewComponentType.AutoPilotTrack] = this.CreateAutoPilotTrackHandle(this.MarkComponentContext);
		}

		// Token: 0x0602C8F1 RID: 182513 RVA: 0x00C82D34 File Offset: 0x00C80F34
		private void UpdateComponentHandles()
		{
			if (!this.MarkComponentContext.CanExecuteComponentLogic())
			{
				return;
			}
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.UpdateNoCheck();
			}
		}

		// Token: 0x0602C8F2 RID: 182514 RVA: 0x00C82D98 File Offset: 0x00C80F98
		private void ApplyComponentHandlesModified()
		{
			if (!this.MarkComponentContext.CanExecuteComponentLogic())
			{
				return;
			}
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.ApplyModifiedNoCheck();
			}
		}

		// Token: 0x0602C8F3 RID: 182515 RVA: 0x00C82DFC File Offset: 0x00C80FFC
		private void ResetComponentHandlesVisibleState()
		{
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.ResetVisibleState();
			}
		}

		// Token: 0x0602C8F4 RID: 182516 RVA: 0x00C82E54 File Offset: 0x00C81054
		private void RecycleHandles()
		{
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.SetVisible(false);
				markItemHandle.ApplyModified();
			}
		}

		// Token: 0x0602C8F5 RID: 182517 RVA: 0x00C82EB0 File Offset: 0x00C810B0
		private void DisposeComponentHandles()
		{
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.Dispose();
			}
			this.MarkItemComponentHandleMap.Clear();
		}

		// Token: 0x0602C8F6 RID: 182518 RVA: 0x00C82F10 File Offset: 0x00C81110
		protected virtual IMarkItemHandle CreateTopRightHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemTopRightIconHandle(markComponentContext);
		}

		// Token: 0x0602C8F7 RID: 182519 RVA: 0x00C82F18 File Offset: 0x00C81118
		protected virtual IMarkItemHandle CreateRangeHandle<[Nullable(0)] T>(IMarkItemComponentContext markComponentContext) where T : MarkPanelBase, new()
		{
			return new MarkItemRangeHandle<T>(markComponentContext);
		}

		// Token: 0x0602C8F8 RID: 182520 RVA: 0x00C82F20 File Offset: 0x00C81120
		protected virtual IMarkItemHandle CreateNameHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemNameHandle(markComponentContext);
		}

		// Token: 0x0602C8F9 RID: 182521 RVA: 0x00C82F28 File Offset: 0x00C81128
		protected virtual IMarkItemHandle CreateOutOfBoundHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemOutOfBoundHandle(markComponentContext);
		}

		// Token: 0x0602C8FA RID: 182522 RVA: 0x00C82F30 File Offset: 0x00C81130
		protected virtual IMarkItemHandle CreateSelectHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemSelectHandle(markComponentContext);
		}

		// Token: 0x0602C8FB RID: 182523 RVA: 0x00C82F38 File Offset: 0x00C81138
		protected virtual IMarkItemHandle CreateTrackHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemTrackHandle(markComponentContext);
		}

		// Token: 0x0602C8FC RID: 182524 RVA: 0x00C82F40 File Offset: 0x00C81140
		protected virtual IMarkItemHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemChildIconHandle(markComponentContext);
		}

		// Token: 0x0602C8FD RID: 182525 RVA: 0x00C82F48 File Offset: 0x00C81148
		protected virtual IMarkItemHandle CreateVerticalPointerHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemVerticalPointerHandle(markComponentContext);
		}

		// Token: 0x0602C8FE RID: 182526 RVA: 0x00C82F50 File Offset: 0x00C81150
		protected virtual IMarkItemHandle CreateGravityReverseIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemGravityReverseIconHandle(markComponentContext);
		}

		// Token: 0x0602C8FF RID: 182527 RVA: 0x00C82F58 File Offset: 0x00C81158
		protected virtual IMarkItemHandle CreateAutoPilotTrackHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemAutoPilotTrackHandle(markComponentContext);
		}

		// Token: 0x04017E93 RID: 97939
		public const float SCALE_TWEEN_DURATION = 0.2f;

		// Token: 0x04017E94 RID: 97940
		[Nullable(2)]
		public MarkItem Holder = holder;

		// Token: 0x04017E95 RID: 97941
		private bool MarkLogicSelected;

		// Token: 0x04017E96 RID: 97942
		private double MarkSelectedTime;

		// Token: 0x04017E97 RID: 97943
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x04017E98 RID: 97944
		public bool IsShowIcon = true;

		// Token: 0x04017E99 RID: 97945
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04017E9A RID: 97946
		protected FTransformDouble? AttachParentSocketTransform;

		// Token: 0x04017E9B RID: 97947
		private bool IsScaleChangedLast;

		// Token: 0x04017E9C RID: 97948
		[Nullable(2)]
		protected IMarkItemComponentContext MarkComponentContext;

		// Token: 0x04017E9D RID: 97949
		protected readonly Dictionary<EMarkViewComponentType, IMarkItemHandle> MarkItemComponentHandleMap = new Dictionary<EMarkViewComponentType, IMarkItemHandle>();
	}
}
