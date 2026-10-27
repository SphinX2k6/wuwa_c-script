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
	// Token: 0x02005517 RID: 21783
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkItemView : MarkPanelBase
	{
		// Token: 0x1700859E RID: 34206
		// (get) Token: 0x060379E6 RID: 227814 RVA: 0x00D3405F File Offset: 0x00D3225F
		protected MarkItemTopRightIconHandle MarkItemTopRightIconHandle
		{
			get
			{
				return this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.TopRightIcon) as MarkItemTopRightIconHandle;
			}
		}

		// Token: 0x1700859F RID: 34207
		// (get) Token: 0x060379E7 RID: 227815 RVA: 0x00D34072 File Offset: 0x00D32272
		protected IMarkItemRangeHandle MarkItemRangeHandle
		{
			get
			{
				return this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Range) as IMarkItemRangeHandle;
			}
		}

		// Token: 0x170085A0 RID: 34208
		// (get) Token: 0x060379E8 RID: 227816 RVA: 0x00D34085 File Offset: 0x00D32285
		protected MarkItemNameHandle MarkItemNameHandle
		{
			get
			{
				return (MarkItemNameHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Name);
			}
		}

		// Token: 0x170085A1 RID: 34209
		// (get) Token: 0x060379E9 RID: 227817 RVA: 0x00D34098 File Offset: 0x00D32298
		protected MarkItemOutOfBoundHandle MarkItemOutOfBoundHandle
		{
			get
			{
				return (MarkItemOutOfBoundHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.OutOfBound);
			}
		}

		// Token: 0x170085A2 RID: 34210
		// (get) Token: 0x060379EA RID: 227818 RVA: 0x00D340AB File Offset: 0x00D322AB
		protected MarkItemSelectHandle MarkItemSelectHandle
		{
			get
			{
				return (MarkItemSelectHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Select);
			}
		}

		// Token: 0x170085A3 RID: 34211
		// (get) Token: 0x060379EB RID: 227819 RVA: 0x00D340BE File Offset: 0x00D322BE
		protected MarkItemTrackHandle MarkItemTrackHandle
		{
			get
			{
				return (MarkItemTrackHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.Track);
			}
		}

		// Token: 0x170085A4 RID: 34212
		// (get) Token: 0x060379EC RID: 227820 RVA: 0x00D340D1 File Offset: 0x00D322D1
		protected MarkItemChildIconHandle MarkItemChildIconHandle
		{
			get
			{
				return (MarkItemChildIconHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.ChildIcon);
			}
		}

		// Token: 0x170085A5 RID: 34213
		// (get) Token: 0x060379ED RID: 227821 RVA: 0x00D340E4 File Offset: 0x00D322E4
		protected MarkItemVerticalPointerHandle MarkItemVerticalPointerHandle
		{
			get
			{
				return (MarkItemVerticalPointerHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.VerticalPointer);
			}
		}

		// Token: 0x170085A6 RID: 34214
		// (get) Token: 0x060379EE RID: 227822 RVA: 0x00D340F7 File Offset: 0x00D322F7
		protected MarkItemGravityReverseIconHandle MarkItemGravityReverseIconHandle
		{
			get
			{
				return (MarkItemGravityReverseIconHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.GravityReverse);
			}
		}

		// Token: 0x170085A7 RID: 34215
		// (get) Token: 0x060379EF RID: 227823 RVA: 0x00D3410B File Offset: 0x00D3230B
		protected MarkItemAutoPilotTrackHandle MarkItemAutoPilotTrackHandle
		{
			get
			{
				return (MarkItemAutoPilotTrackHandle)this.MarkItemComponentHandleMap.GetValueOrDefault(EMarkViewComponentType.AutoPilotTrack);
			}
		}

		// Token: 0x170085A8 RID: 34216
		// (get) Token: 0x060379F0 RID: 227824 RVA: 0x00D3411F File Offset: 0x00D3231F
		// (set) Token: 0x060379F1 RID: 227825 RVA: 0x00D34136 File Offset: 0x00D32336
		public bool IsSelected
		{
			get
			{
				return this.Holder.MarkItemEntity.ViewLifeCircle.IsSelected;
			}
			set
			{
				if (this.Holder.MarkItemEntity.ViewLifeCircle.IsSelectedDirty)
				{
					this.OnSelectedStateChange(value);
				}
			}
		}

		// Token: 0x170085A9 RID: 34217
		// (get) Token: 0x060379F2 RID: 227826 RVA: 0x00D34156 File Offset: 0x00D32356
		public bool ViewInitialized
		{
			get
			{
				return this.ViewInitializedInner;
			}
		}

		// Token: 0x060379F3 RID: 227827 RVA: 0x00D3415E File Offset: 0x00D3235E
		public MarkItemView(MarkItem holder)
		{
			this.Holder = holder;
		}

		// Token: 0x060379F4 RID: 227828 RVA: 0x00D3417F File Offset: 0x00D3237F
		protected virtual void OnSelectedStateChange(bool newState)
		{
		}

		// Token: 0x060379F5 RID: 227829 RVA: 0x00D34184 File Offset: 0x00D32384
		public UniTask InitializeMarkItemViewNewAsync(Action createCb)
		{
			MarkItemView.<InitializeMarkItemViewNewAsync>d__39 <InitializeMarkItemViewNewAsync>d__;
			<InitializeMarkItemViewNewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeMarkItemViewNewAsync>d__.<>4__this = this;
			<InitializeMarkItemViewNewAsync>d__.createCb = createCb;
			<InitializeMarkItemViewNewAsync>d__.<>1__state = -1;
			<InitializeMarkItemViewNewAsync>d__.<>t__builder.Start<MarkItemView.<InitializeMarkItemViewNewAsync>d__39>(ref <InitializeMarkItemViewNewAsync>d__);
			return <InitializeMarkItemViewNewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060379F6 RID: 227830 RVA: 0x00D341CF File Offset: 0x00D323CF
		public void InitializeData(MarkItem holder)
		{
			this.Holder = holder;
			this.OnDataInitialized(this.Holder);
		}

		// Token: 0x060379F7 RID: 227831 RVA: 0x00D341E4 File Offset: 0x00D323E4
		public unsafe void InitializeView()
		{
			if (this.ViewInitializedInner)
			{
				return;
			}
			this.ViewInitializedInner = true;
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

		// Token: 0x060379F8 RID: 227832 RVA: 0x00D34348 File Offset: 0x00D32548
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
			this.MarkComponentContext.MarkItemEntity = this.Holder.MarkItemEntity;
			this.MarkComponentContext.MarkItem = this.Holder;
			this.MarkComponentContext.MarkParentItem = this.RootItem.GetParentAsUIItem();
			this.MarkComponentContext.MarkRootItem = this.RootItem;
			this.ResetScale();
			this.ResetIcon();
			this.OnViewRefresh();
			base.DoRegisterEvents();
		}

		// Token: 0x060379F9 RID: 227833 RVA: 0x00D343E5 File Offset: 0x00D325E5
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

		// Token: 0x060379FA RID: 227834 RVA: 0x00D3441B File Offset: 0x00D3261B
		public override void RecycleToPool()
		{
			this.DestroyView();
			base.RecycleToPool();
		}

		// Token: 0x060379FB RID: 227835 RVA: 0x00D34429 File Offset: 0x00D32629
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

		// Token: 0x060379FC RID: 227836 RVA: 0x00D34460 File Offset: 0x00D32660
		public void ClearData()
		{
			this.AttachParentSocketTransform = null;
			this.Holder = null;
		}

		// Token: 0x060379FD RID: 227837 RVA: 0x00D34475 File Offset: 0x00D32675
		protected virtual void OnDataInitialized(MarkItem holder)
		{
		}

		// Token: 0x060379FE RID: 227838 RVA: 0x00D34477 File Offset: 0x00D32677
		protected virtual void OnViewInitialize()
		{
		}

		// Token: 0x060379FF RID: 227839 RVA: 0x00D34479 File Offset: 0x00D32679
		protected virtual void OnViewRefresh()
		{
		}

		// Token: 0x06037A00 RID: 227840 RVA: 0x00D3447B File Offset: 0x00D3267B
		protected virtual void OnViewRecycle()
		{
		}

		// Token: 0x06037A01 RID: 227841 RVA: 0x00D3447D File Offset: 0x00D3267D
		[NullableContext(2)]
		public virtual UUIItem GetIconItem()
		{
			return base.GetSprite(1);
		}

		// Token: 0x06037A02 RID: 227842 RVA: 0x00D34488 File Offset: 0x00D32688
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

		// Token: 0x06037A03 RID: 227843 RVA: 0x00D34554 File Offset: 0x00D32754
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

		// Token: 0x06037A04 RID: 227844 RVA: 0x00D3457C File Offset: 0x00D3277C
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

		// Token: 0x06037A05 RID: 227845 RVA: 0x00D345D2 File Offset: 0x00D327D2
		protected void RefreshActorLabel()
		{
		}

		// Token: 0x06037A06 RID: 227846 RVA: 0x00D345D4 File Offset: 0x00D327D4
		protected void RefreshParentSocketTransform()
		{
			FName attachSocketName = this.RootItem.GetAttachSocketName();
			USceneComponent attachParent = this.RootItem.GetAttachParent();
			this.AttachParentSocketTransform = new FTransformDouble?(attachParent.D_GetSocketTransform(attachSocketName, ERelativeTransformSpace.RTS_World));
		}

		// Token: 0x06037A07 RID: 227847 RVA: 0x00D3460C File Offset: 0x00D3280C
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

		// Token: 0x06037A08 RID: 227848 RVA: 0x00D34664 File Offset: 0x00D32864
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

		// Token: 0x06037A09 RID: 227849 RVA: 0x00D34702 File Offset: 0x00D32902
		protected bool IsHolderValid()
		{
			return this.Holder != null && this.AttachParentSocketTransform != null;
		}

		// Token: 0x170085AA RID: 34218
		// (get) Token: 0x06037A0A RID: 227850 RVA: 0x00D3471E File Offset: 0x00D3291E
		public bool IsViewReady
		{
			get
			{
				return !base.IsCreating && !base.IsDestroyOrDestroying && !base.IsHideOrHiding;
			}
		}

		// Token: 0x06037A0B RID: 227851 RVA: 0x00D3473C File Offset: 0x00D3293C
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

		// Token: 0x06037A0C RID: 227852 RVA: 0x00D347FD File Offset: 0x00D329FD
		public void ApplyOutOfBoundActive()
		{
			MarkItemOutOfBoundHandle markItemOutOfBoundHandle = this.MarkItemOutOfBoundHandle;
			if (markItemOutOfBoundHandle == null)
			{
				return;
			}
			markItemOutOfBoundHandle.ApplyModified();
		}

		// Token: 0x06037A0D RID: 227853 RVA: 0x00D34810 File Offset: 0x00D32A10
		private void UpdateComponents(global::Vector playerLocation, bool bDragging = false)
		{
			MarkItemTrackHandle markItemTrackHandle = this.MarkItemTrackHandle;
			if (markItemTrackHandle != null)
			{
				markItemTrackHandle.SetVisible(this.Holder.IsTracked && !bDragging);
			}
			MarkItemSelectHandle markItemSelectHandle = this.MarkItemSelectHandle;
			if (markItemSelectHandle != null)
			{
				markItemSelectHandle.SetVisible(this.IsSelected);
			}
			MarkItemVerticalPointerHandle markItemVerticalPointerHandle = this.MarkItemVerticalPointerHandle;
			if (markItemVerticalPointerHandle != null)
			{
				markItemVerticalPointerHandle.UpdateVerticalPointerType(this.Holder.WorldPosition, playerLocation);
			}
			MarkItemAutoPilotTrackHandle markItemAutoPilotTrackHandle = this.MarkItemAutoPilotTrackHandle;
			if (markItemAutoPilotTrackHandle != null)
			{
				markItemAutoPilotTrackHandle.SetVisible(this.Holder.IsAutoPilotTracked);
			}
			this.UpdateComponentHandles();
		}

		// Token: 0x06037A0E RID: 227854 RVA: 0x00D34898 File Offset: 0x00D32A98
		protected virtual void OnSafeUpdate(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
		}

		// Token: 0x06037A0F RID: 227855 RVA: 0x00D3489A File Offset: 0x00D32A9A
		protected virtual void OnLateUpdate()
		{
			this.UpdateGravityIcon();
			this.ApplyComponentHandlesModified();
		}

		// Token: 0x06037A10 RID: 227856 RVA: 0x00D348A8 File Offset: 0x00D32AA8
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

		// Token: 0x06037A11 RID: 227857 RVA: 0x00D3493A File Offset: 0x00D32B3A
		public virtual void OnStartTrack()
		{
		}

		// Token: 0x06037A12 RID: 227858 RVA: 0x00D3493C File Offset: 0x00D32B3C
		public virtual void OnEndTrack()
		{
		}

		// Token: 0x06037A13 RID: 227859 RVA: 0x00D3493E File Offset: 0x00D32B3E
		private void ResetIcon()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
			this.UpdateGravityIcon();
		}

		// Token: 0x06037A14 RID: 227860 RVA: 0x00D34958 File Offset: 0x00D32B58
		private void UpdateGravityIcon()
		{
			if (this.Holder.MarkItemEntity.ViewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.GravityReverse))
			{
				base.GetSprite(1).SetAlpha(this.Holder.MarkItemEntity.GamePlay.InGravityLayer ? 1f : 0.4f);
			}
		}

		// Token: 0x06037A15 RID: 227861 RVA: 0x00D349B0 File Offset: 0x00D32BB0
		public virtual void OnIconPathChanged(string iconPath)
		{
			UUISprite sprite = base.GetSprite(1);
			this.LoadIcon(sprite, iconPath);
		}

		// Token: 0x06037A16 RID: 227862 RVA: 0x00D349D0 File Offset: 0x00D32BD0
		protected void LoadIcon(UUISprite iconComponent, string iconPath)
		{
			if (ObjectUtils.IsValid(iconComponent))
			{
				if (!string.IsNullOrEmpty(iconPath))
				{
					this.SetSpriteByPath(iconPath, iconComponent, false, null, delegate(bool result)
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
		}

		// Token: 0x06037A17 RID: 227863 RVA: 0x00D34A36 File Offset: 0x00D32C36
		public virtual bool GetInteractiveFlag()
		{
			MarkItem holder = this.Holder;
			return holder != null && holder.IsCanShowView;
		}

		// Token: 0x06037A18 RID: 227864 RVA: 0x00D34A49 File Offset: 0x00D32C49
		protected virtual void OnLevelSequenceStart(string sequenceName)
		{
			MarkItem holder = this.Holder;
			if (holder == null)
			{
				return;
			}
			holder.OnLevelSequenceStart(sequenceName);
		}

		// Token: 0x06037A19 RID: 227865 RVA: 0x00D34A5C File Offset: 0x00D32C5C
		protected virtual void OnLevelSequenceStop(string sequenceName)
		{
			MarkItem holder = this.Holder;
			if (holder != null)
			{
				holder.OnLevelSequenceStop(sequenceName);
			}
			if (sequenceName == "HideView")
			{
				bool uiActive = this.Holder.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.MarkView, false);
				base.SetUiActive(uiActive);
				UUIItem item = base.GetItem(0);
				if (item == null)
				{
					return;
				}
				item.SetAlpha(1f);
			}
		}

		// Token: 0x06037A1A RID: 227866 RVA: 0x00D34AC0 File Offset: 0x00D32CC0
		protected void PlayInShowScaleRangeSequence()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("ShowView", false, null, false);
		}

		// Token: 0x06037A1B RID: 227867 RVA: 0x00D34AF8 File Offset: 0x00D32CF8
		protected void PlayOutShowScaleRangeSequence()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("HideView", false, null, false);
		}

		// Token: 0x06037A1C RID: 227868 RVA: 0x00D34B2D File Offset: 0x00D32D2D
		public virtual UniTask PlayUnlockSequence()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06037A1D RID: 227869 RVA: 0x00D34B34 File Offset: 0x00D32D34
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

		// Token: 0x06037A1E RID: 227870 RVA: 0x00D34BD4 File Offset: 0x00D32DD4
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

		// Token: 0x06037A1F RID: 227871 RVA: 0x00D34C94 File Offset: 0x00D32E94
		private bool IsOnScaleTween()
		{
			return this.MarkSelectedTime > 0.0 && this.MarkSelectedTime + 0.20000000298023224 >= Time.Instance.NowSeconds;
		}

		// Token: 0x06037A20 RID: 227872 RVA: 0x00D34CC8 File Offset: 0x00D32EC8
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x06037A21 RID: 227873 RVA: 0x00D34CF4 File Offset: 0x00D32EF4
		public void OnRecycle()
		{
			this.RecycleHandles();
			this.LevelSequencePlayer.StopCurrentSequence(false, true);
			MarkSpritePool.UnRef(this.ComponentId);
			this.ClearTimer();
		}

		// Token: 0x06037A22 RID: 227874 RVA: 0x00D34D1A File Offset: 0x00D32F1A
		protected void ApplyRootAnchorOffset()
		{
			this.RootItem.SetAnchorOffset(Vector2D.Create(this.Holder.InitUiPosition.X, this.Holder.InitUiPosition.Y).ToUeVector2D(false));
		}

		// Token: 0x06037A23 RID: 227875 RVA: 0x00D34D54 File Offset: 0x00D32F54
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

		// Token: 0x06037A24 RID: 227876 RVA: 0x00D34DC8 File Offset: 0x00D32FC8
		private void InitComponentHandles()
		{
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.Init();
			}
		}

		// Token: 0x06037A25 RID: 227877 RVA: 0x00D34E20 File Offset: 0x00D33020
		protected virtual void CreateComponentHandles()
		{
			base.GetSprite(4).bNotUseDynamicSpriteAtlas = true;
			this.MarkComponentContext = new MarkItemComponentContext
			{
				MarkItemEntity = this.Holder.MarkItemEntity,
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

		// Token: 0x06037A26 RID: 227878 RVA: 0x00D34FA0 File Offset: 0x00D331A0
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

		// Token: 0x06037A27 RID: 227879 RVA: 0x00D35004 File Offset: 0x00D33204
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

		// Token: 0x06037A28 RID: 227880 RVA: 0x00D35068 File Offset: 0x00D33268
		private void RecycleHandles()
		{
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.SetVisible(false);
				markItemHandle.ApplyModified();
			}
		}

		// Token: 0x06037A29 RID: 227881 RVA: 0x00D350C4 File Offset: 0x00D332C4
		private void DisposeComponentHandles()
		{
			foreach (IMarkItemHandle markItemHandle in this.MarkItemComponentHandleMap.Values)
			{
				markItemHandle.Dispose();
			}
			this.MarkItemComponentHandleMap.Clear();
		}

		// Token: 0x06037A2A RID: 227882 RVA: 0x00D35124 File Offset: 0x00D33324
		protected virtual IMarkItemHandle CreateTopRightHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemTopRightIconHandle(markComponentContext);
		}

		// Token: 0x06037A2B RID: 227883 RVA: 0x00D3512C File Offset: 0x00D3332C
		protected virtual IMarkItemHandle CreateRangeHandle<[Nullable(0)] T>(IMarkItemComponentContext markComponentContext) where T : MarkPanelBase, new()
		{
			return new MarkItemRangeHandle<T>(markComponentContext);
		}

		// Token: 0x06037A2C RID: 227884 RVA: 0x00D35134 File Offset: 0x00D33334
		protected virtual IMarkItemHandle CreateNameHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemNameHandle(markComponentContext);
		}

		// Token: 0x06037A2D RID: 227885 RVA: 0x00D3513C File Offset: 0x00D3333C
		protected virtual IMarkItemHandle CreateOutOfBoundHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemOutOfBoundHandle(markComponentContext);
		}

		// Token: 0x06037A2E RID: 227886 RVA: 0x00D35144 File Offset: 0x00D33344
		protected virtual IMarkItemHandle CreateSelectHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemSelectHandle(markComponentContext);
		}

		// Token: 0x06037A2F RID: 227887 RVA: 0x00D3514C File Offset: 0x00D3334C
		protected virtual IMarkItemHandle CreateTrackHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemTrackHandle(markComponentContext);
		}

		// Token: 0x06037A30 RID: 227888 RVA: 0x00D35154 File Offset: 0x00D33354
		protected virtual IMarkItemHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemChildIconHandle(markComponentContext);
		}

		// Token: 0x06037A31 RID: 227889 RVA: 0x00D3515C File Offset: 0x00D3335C
		protected virtual IMarkItemHandle CreateVerticalPointerHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemVerticalPointerHandle(markComponentContext);
		}

		// Token: 0x06037A32 RID: 227890 RVA: 0x00D35164 File Offset: 0x00D33364
		protected virtual IMarkItemHandle CreateGravityReverseIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemGravityReverseIconHandle(markComponentContext);
		}

		// Token: 0x06037A33 RID: 227891 RVA: 0x00D3516C File Offset: 0x00D3336C
		protected virtual IMarkItemHandle CreateAutoPilotTrackHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MarkItemAutoPilotTrackHandle(markComponentContext);
		}

		// Token: 0x0401D40F RID: 119823
		public const float SCALE_TWEEN_DURATION = 0.2f;

		// Token: 0x0401D410 RID: 119824
		[Nullable(2)]
		public MarkItem Holder;

		// Token: 0x0401D411 RID: 119825
		private bool MarkLogicSelected;

		// Token: 0x0401D412 RID: 119826
		private double MarkSelectedTime;

		// Token: 0x0401D413 RID: 119827
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0401D414 RID: 119828
		public bool IsShowIcon = true;

		// Token: 0x0401D415 RID: 119829
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D416 RID: 119830
		protected FTransformDouble? AttachParentSocketTransform;

		// Token: 0x0401D417 RID: 119831
		private bool IsScaleChangedLast;

		// Token: 0x0401D418 RID: 119832
		[Nullable(2)]
		protected IMarkItemComponentContext MarkComponentContext;

		// Token: 0x0401D419 RID: 119833
		protected readonly Dictionary<EMarkViewComponentType, IMarkItemHandle> MarkItemComponentHandleMap = new Dictionary<EMarkViewComponentType, IMarkItemHandle>();

		// Token: 0x0401D41A RID: 119834
		private bool ViewInitializedInner;
	}
}
