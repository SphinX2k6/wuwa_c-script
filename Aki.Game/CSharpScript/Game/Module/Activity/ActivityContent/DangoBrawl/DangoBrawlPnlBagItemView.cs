using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067F3 RID: 26611
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlBagItemView : DangoBrawlViewItemBase, ICombineLineOwner
	{
		// Token: 0x1700970C RID: 38668
		// (get) Token: 0x0604252A RID: 271658 RVA: 0x0101AA2E File Offset: 0x01018C2E
		private DangoBrawlBackpackItemData BagItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x1700970D RID: 38669
		// (get) Token: 0x0604252B RID: 271659 RVA: 0x0101AA3B File Offset: 0x01018C3B
		private DangoBrawlBenchItemData BenchItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBenchItemData;
			}
		}

		// Token: 0x1700970E RID: 38670
		// (get) Token: 0x0604252C RID: 271660 RVA: 0x0101AA48 File Offset: 0x01018C48
		private DangoBrawlDataController DataController
		{
			get
			{
				return DangoBrawlModel.Instance.GetDataController();
			}
		}

		// Token: 0x1700970F RID: 38671
		// (get) Token: 0x0604252D RID: 271661 RVA: 0x0101AA54 File Offset: 0x01018C54
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(18);
			}
		}

		// Token: 0x17009710 RID: 38672
		// (get) Token: 0x0604252E RID: 271662 RVA: 0x0101AA5E File Offset: 0x01018C5E
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(24);
			}
		}

		// Token: 0x0604252F RID: 271663 RVA: 0x0101AA68 File Offset: 0x01018C68
		protected override EDangoBrawlRotate GetBoundRotate()
		{
			if (this.BagItemData != null)
			{
				return this.BagItemData.MyRotation;
			}
			DangoBrawlBenchItemData benchItemData = this.BenchItemData;
			if (benchItemData == null)
			{
				return EDangoBrawlRotate.Direction0;
			}
			return benchItemData.MyRotation;
		}

		// Token: 0x06042530 RID: 271664 RVA: 0x0101AA90 File Offset: 0x01018C90
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(14, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(15, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(17, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(18, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(24, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(19, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(23, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(25, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(21, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(22, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(26, typeof(UUINiagara)));
		}

		// Token: 0x06042531 RID: 271665 RVA: 0x0101AC2C File Offset: 0x01018E2C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlBagItemView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042532 RID: 271666 RVA: 0x0101AC6F File Offset: 0x01018E6F
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			DangoBrawlItemViewRegistry viewRegistry = DangoBrawlModel.Instance.GetViewRegistry();
			if (viewRegistry != null)
			{
				viewRegistry.UnregisterLineOwner(base.MyUid, this);
			}
			this.UnBindEvents();
			this.ClearCombineLines();
			this.ClearCombineFlyTween();
		}

		// Token: 0x06042533 RID: 271667 RVA: 0x0101ACA8 File Offset: 0x01018EA8
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
		}

		// Token: 0x06042534 RID: 271668 RVA: 0x0101AD0C File Offset: 0x01018F0C
		private void UnBindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
		}

		// Token: 0x06042535 RID: 271669 RVA: 0x0101AD70 File Offset: 0x01018F70
		public override void RefreshView()
		{
			EDangoBrawlRotate boundRotate = this.GetBoundRotate();
			base.RefreshView();
			this.RefreshRotation(boundRotate);
			this.RefreshWeight();
			this.RefreshUniqueWeapon();
			this.RefreshMobileTips();
			this.RefreshQualityFx(base.GetItem(21), base.GetItem(22), base.GetUiNiagara(26));
			if (base.ShouldLayoutInGrid())
			{
				this.RefreshBagPosition();
			}
			this.SetCombineGuideLineReason(ECombineLineShowReason.Drag, false);
		}

		// Token: 0x06042536 RID: 271670 RVA: 0x0101ADD7 File Offset: 0x01018FD7
		[NullableContext(1)]
		protected override void CollectIconTextures(List<UUITexture> textures)
		{
			base.CollectIconTextures(textures);
			if (this.SprIconMask02 != null)
			{
				textures.Add(this.SprIconMask02);
			}
			if (this.SprIconMask03 != null)
			{
				textures.Add(this.SprIconMask03);
			}
		}

		// Token: 0x06042537 RID: 271671 RVA: 0x0101AE08 File Offset: 0x01019008
		protected override void RefreshRotation(EDangoBrawlRotate val)
		{
			this.RefreshPosFromRotate(val);
			this.RefreshStarsView(val);
		}

		// Token: 0x06042538 RID: 271672 RVA: 0x0101AE18 File Offset: 0x01019018
		public override void SetSelectedVisualState(bool enable)
		{
			base.SetSelectedVisualState(enable);
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Selected, enable);
		}

		// Token: 0x06042539 RID: 271673 RVA: 0x0101AE29 File Offset: 0x01019029
		private void InitFxScale()
		{
			UUIItem item = base.GetItem(25);
			if (item == null)
			{
				return;
			}
			item.SetRelativeScale3D(DangoBrawlUtil.GetFxScale(this.ItemData.MyConfigId, EDangoBrawlRotate.Direction0));
		}

		// Token: 0x0604253A RID: 271674 RVA: 0x0101AE50 File Offset: 0x01019050
		private void RefreshMobileTips()
		{
			DangoBrawlTouchController touch = base.Touch;
			EInputPlatform? einputPlatform = (touch != null) ? new EInputPlatform?(touch.GetInputPlatform()) : null;
			UUIItem item = base.GetItem(23);
			if (item == null)
			{
				return;
			}
			EInputPlatform? einputPlatform2 = einputPlatform;
			EInputPlatform einputPlatform3 = EInputPlatform.Mobile;
			bool uiactive;
			if (einputPlatform2.GetValueOrDefault() == einputPlatform3 & einputPlatform2 != null)
			{
				InteractionStateMachine fsm = base.Fsm;
				if (fsm != null && fsm.CheckIsInState(base.Uid, EInteractionState.Holding))
				{
					DangoBrawlOperationDispatcher operations = base.Operations;
					uiactive = (operations != null && operations.CanExecute(EDangoBrawlOptionType.Confim, -1));
					goto IL_77;
				}
			}
			uiactive = false;
			IL_77:
			item.SetUIActive(uiactive);
		}

		// Token: 0x0604253B RID: 271675 RVA: 0x0101AED9 File Offset: 0x010190D9
		public void PlayStarActiveSeq(int idx)
		{
			if (idx < 0 || idx >= this.StarPanels.Count)
			{
				return;
			}
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Activating, true);
			DangoBrawlGeneralStar dangoBrawlGeneralStar = this.StarPanels[idx];
			if (dangoBrawlGeneralStar == null)
			{
				return;
			}
			dangoBrawlGeneralStar.PlayActiveSeq(delegate
			{
				this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Activating, false);
			});
		}

		// Token: 0x0604253C RID: 271676 RVA: 0x0101AF18 File Offset: 0x01019118
		public void PlayItemActiveSeq()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Activate", false, null);
		}

		// Token: 0x0604253D RID: 271677 RVA: 0x0101AF44 File Offset: 0x01019144
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x0604253E RID: 271678 RVA: 0x0101AF4C File Offset: 0x0101914C
		private void OnItemHoveredChange(int uid, EDragSourceKind source)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x0604253F RID: 271679 RVA: 0x0101AF54 File Offset: 0x01019154
		public override void OnDragSourceBegin()
		{
			base.OnDragSourceBegin();
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Drag, true);
			this.SetCombineGuideLineReason(ECombineLineShowReason.Drag, true);
			this.RefreshMobileTips();
		}

		// Token: 0x06042540 RID: 271680 RVA: 0x0101AF72 File Offset: 0x01019172
		public override void OnDragSourceEnd()
		{
			base.OnDragSourceEnd();
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Drag, false);
			this.SetCombineGuideLineReason(ECombineLineShowReason.Drag, false);
			this.RefreshMobileTips();
		}

		// Token: 0x06042541 RID: 271681 RVA: 0x0101AF90 File Offset: 0x01019190
		public override void OnMoving()
		{
			base.OnMoving();
			this.RefreshCombineLineAngles();
			this.RefreshStarFillByWorldPos();
		}

		// Token: 0x06042542 RID: 271682 RVA: 0x0101AFA4 File Offset: 0x010191A4
		protected override void OnPointerEnter(EToggleState _)
		{
			DangoBrawlTouchController touch = base.Touch;
			EInputPlatform? einputPlatform = (touch != null) ? new EInputPlatform?(touch.GetInputPlatform()) : null;
			EInputPlatform einputPlatform2 = EInputPlatform.Mobile;
			if (einputPlatform.GetValueOrDefault() == einputPlatform2 & einputPlatform != null)
			{
				return;
			}
			if (DangoBrawlViewManager.TryBlockHoverEffect())
			{
				return;
			}
			base.OnPointerEnter(_);
			UUIItem ownerRootItem = this.GetOwnerRootItem();
			if (ownerRootItem != null)
			{
				ownerRootItem.SetAsLastHierarchy();
			}
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Hover, true);
			this.SetCombineGuideLineReason(ECombineLineShowReason.Hover, true);
		}

		// Token: 0x06042543 RID: 271683 RVA: 0x0101B018 File Offset: 0x01019218
		protected override void OnPointerExit(EToggleState _)
		{
			base.OnPointerExit(_);
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Hover, false);
			this.SetCombineGuideLineReason(ECombineLineShowReason.Hover, false);
		}

		// Token: 0x06042544 RID: 271684 RVA: 0x0101B031 File Offset: 0x01019231
		protected override void OnDangoBrawlLayerModeChanged(bool isLayerMode)
		{
			base.OnDangoBrawlLayerModeChanged(isLayerMode);
			UUIDraggableComponent draggableComponent = base.DraggableComponent;
			if (draggableComponent == null)
			{
				return;
			}
			UUIItem rootComponent = draggableComponent.GetRootComponent();
			if (rootComponent == null)
			{
				return;
			}
			rootComponent.SetUIActive(!isLayerMode);
		}

		// Token: 0x06042545 RID: 271685 RVA: 0x0101B058 File Offset: 0x01019258
		private void RefreshBagPosition()
		{
			if (this.BagItemData == null || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			PanelPos myLeftTopPos = this.BagItemData.MyLeftTopPos;
			this.RootItem.SetUIRelativeLocation(new FVector((float)(myLeftTopPos.ColIndex * this.GridSize), (float)(-(float)myLeftTopPos.RowIndex * this.GridSize), 0f));
		}

		// Token: 0x06042546 RID: 271686 RVA: 0x0101B0C4 File Offset: 0x010192C4
		private UniTask CreateStarPanels(int total)
		{
			DangoBrawlPnlBagItemView.<CreateStarPanels>d__40 <CreateStarPanels>d__;
			<CreateStarPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateStarPanels>d__.<>4__this = this;
			<CreateStarPanels>d__.total = total;
			<CreateStarPanels>d__.<>1__state = -1;
			<CreateStarPanels>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<CreateStarPanels>d__40>(ref <CreateStarPanels>d__);
			return <CreateStarPanels>d__.<>t__builder.Task;
		}

		// Token: 0x06042547 RID: 271687 RVA: 0x0101B110 File Offset: 0x01019310
		private void SetStarsContentActive(bool val)
		{
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetAlpha(val > false);
			}
			if (val)
			{
				EDangoBrawlRotate rotate = this.ResolveVisualRotate();
				this.RefreshStarsView(rotate);
			}
		}

		// Token: 0x06042548 RID: 271688 RVA: 0x0101B148 File Offset: 0x01019348
		private EDangoBrawlRotate ResolveVisualRotate()
		{
			DangoBrawlTouchController touch = base.Touch;
			IDragVisual dragVisual = (touch != null) ? touch.DraggingVisual : null;
			if (dragVisual != null && dragVisual.SourceUid == base.Uid)
			{
				return dragVisual.Rotate;
			}
			DangoBrawlTouchController touch2 = base.Touch;
			IDragVisual dragVisual2;
			if (touch2 == null)
			{
				dragVisual2 = null;
			}
			else
			{
				InteractionPayload payLoad = touch2.GetInteractionFsm().GetPayLoad();
				dragVisual2 = ((payLoad != null) ? payLoad.Visual : null);
			}
			IDragVisual dragVisual3 = dragVisual2;
			if (dragVisual3 != null && dragVisual3.SourceUid == base.Uid)
			{
				return dragVisual3.Rotate;
			}
			return this.GetBoundRotate();
		}

		// Token: 0x06042549 RID: 271689 RVA: 0x0101B1C4 File Offset: 0x010193C4
		private void SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason reason, bool on)
		{
			DangoBrawlPnlBagItemView.EStarShowReason estarShowReason = on ? (this.StarReasons | reason) : (this.StarReasons & ~reason);
			if (estarShowReason == this.StarReasons)
			{
				return;
			}
			this.StarReasons = estarShowReason;
			this.SetStarsContentActive(this.StarReasons > DangoBrawlPnlBagItemView.EStarShowReason.None);
		}

		// Token: 0x0604254A RID: 271690 RVA: 0x0101B208 File Offset: 0x01019408
		private int ResolveStarCount()
		{
			if (this.BagItemData != null)
			{
				return this.BagItemData.MyStarPanelPosList.Length;
			}
			if (this.BenchItemData != null)
			{
				return DangoBrawlUtil.RotateStarPanelPosList(this.BenchItemData.MyConfigId, EDangoBrawlRotate.Direction0).Length;
			}
			return 0;
		}

		// Token: 0x0604254B RID: 271691 RVA: 0x0101B240 File Offset: 0x01019440
		private void RefreshStarsView(EDangoBrawlRotate rotate)
		{
			if (this.BagItemData != null && this.BenchItemData != null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.LSH, "[RefreshStars]：背包数据与备战席数据同时存在！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.BagItemData != null)
			{
				this.RefreshStarsBag(rotate).Forget();
				return;
			}
			if (this.BenchItemData != null)
			{
				this.RefreshStarsBench(rotate).Forget();
			}
		}

		// Token: 0x0604254C RID: 271692 RVA: 0x0101B2A8 File Offset: 0x010194A8
		private UniTask RefreshStarsBag(EDangoBrawlRotate rotate)
		{
			DangoBrawlPnlBagItemView.<RefreshStarsBag>d__46 <RefreshStarsBag>d__;
			<RefreshStarsBag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshStarsBag>d__.<>4__this = this;
			<RefreshStarsBag>d__.rotate = rotate;
			<RefreshStarsBag>d__.<>1__state = -1;
			<RefreshStarsBag>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<RefreshStarsBag>d__46>(ref <RefreshStarsBag>d__);
			return <RefreshStarsBag>d__.<>t__builder.Task;
		}

		// Token: 0x0604254D RID: 271693 RVA: 0x0101B2F4 File Offset: 0x010194F4
		private UniTask RefreshStarsBench(EDangoBrawlRotate rotate)
		{
			DangoBrawlPnlBagItemView.<RefreshStarsBench>d__47 <RefreshStarsBench>d__;
			<RefreshStarsBench>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshStarsBench>d__.<>4__this = this;
			<RefreshStarsBench>d__.rotate = rotate;
			<RefreshStarsBench>d__.<>1__state = -1;
			<RefreshStarsBench>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<RefreshStarsBench>d__47>(ref <RefreshStarsBench>d__);
			return <RefreshStarsBench>d__.<>t__builder.Task;
		}

		// Token: 0x0604254E RID: 271694 RVA: 0x0101B33F File Offset: 0x0101953F
		private void RefreshStarFillByWorldPos()
		{
			IReadOnlyList<DangoBrawlGeneralStar> starPanels = this.StarPanels;
			DangoBrawlTouchController touch = base.Touch;
			DangoBrawlStarUtil.RefreshStarFillByWorldPos(starPanels, (touch != null) ? touch.GetBagDropZoneExtra() : null, this.ActData, base.MyUid);
		}

		// Token: 0x0604254F RID: 271695 RVA: 0x0101B36C File Offset: 0x0101956C
		private UniTask CreateCostPanel()
		{
			DangoBrawlPnlBagItemView.<CreateCostPanel>d__49 <CreateCostPanel>d__;
			<CreateCostPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCostPanel>d__.<>4__this = this;
			<CreateCostPanel>d__.<>1__state = -1;
			<CreateCostPanel>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<CreateCostPanel>d__49>(ref <CreateCostPanel>d__);
			return <CreateCostPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06042550 RID: 271696 RVA: 0x0101B3AF File Offset: 0x010195AF
		public UUIItem GetWeightRootItem()
		{
			return base.GetItem(11);
		}

		// Token: 0x06042551 RID: 271697 RVA: 0x0101B3BC File Offset: 0x010195BC
		private void RefreshWeight()
		{
			if (this.WeightPanel == null)
			{
				return;
			}
			this.WeightPanel.BindData(this.ItemData.MyConfigId);
			DangoBrawlDataController dataController = this.DataController;
			int num = (dataController != null) ? dataController.GetDisplayCost() : 0;
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int num2 = (selfFighter != null) ? selfFighter.Cost : 0;
			this.WeightPanel.RefreshOverLimitView(num > num2);
		}

		// Token: 0x06042552 RID: 271698 RVA: 0x0101B428 File Offset: 0x01019628
		private void OnCostChanged()
		{
			if (this.WeightPanel == null)
			{
				return;
			}
			DangoBrawlDataController dataController = this.DataController;
			int num = (dataController != null) ? dataController.GetDisplayCost() : 0;
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int num2 = (selfFighter != null) ? selfFighter.Cost : 0;
			this.WeightPanel.RefreshOverLimitView(num > num2);
		}

		// Token: 0x06042553 RID: 271699 RVA: 0x0101B480 File Offset: 0x01019680
		private void RefreshUniqueWeapon()
		{
			DangoBrawlItem? dangoBrawlItem;
			bool uiactive = DangoBrawlConfig.Instance.GetItemConfigById(this.ItemData.MyConfigId) != null && dangoBrawlItem.GetValueOrDefault().IsSpeItem;
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06042554 RID: 271700 RVA: 0x0101B4D4 File Offset: 0x010196D4
		private void InitCombineLines()
		{
			UUIItem item = base.GetItem(15);
			UUIItem item2 = base.GetItem(14);
			if (item == null || item2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[BagItemView] InitCombineLines template or container null uid=");
				DangoBrawlItemBase itemData = this.ItemData;
				defaultInterpolatedStringHandler.AppendFormatted<int?>((itemData != null) ? new int?(itemData.MyUid) : null);
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost != null)
			{
				lineHost.Destroy();
			}
			this.LineHost = new DangoBrawlCombineGuideLineHost(this, base.GetDragSourceKind(), this.ActData, item, item2);
		}

		// Token: 0x06042555 RID: 271701 RVA: 0x0101B583 File Offset: 0x01019783
		private void ClearCombineLines()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost != null)
			{
				lineHost.Destroy();
			}
			this.LineHost = null;
		}

		// Token: 0x06042556 RID: 271702 RVA: 0x0101B59D File Offset: 0x0101979D
		public void RefreshCombineLineAngles()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.RefreshAnglesAndPartners();
		}

		// Token: 0x06042557 RID: 271703 RVA: 0x0101B5AF File Offset: 0x010197AF
		public void RebuildCombineGuideLinesIfShowing()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.RebuildShowing();
		}

		// Token: 0x06042558 RID: 271704 RVA: 0x0101B5C1 File Offset: 0x010197C1
		public void SetCombineGuideLineReason(ECombineLineShowReason season, bool show)
		{
			if (show && !DangoBrawlViewManager.TryBlockIfLayerMode(false))
			{
				DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
				if (lineHost == null)
				{
					return;
				}
				lineHost.SetReason(season, true);
				return;
			}
			else
			{
				DangoBrawlCombineGuideLineHost lineHost2 = this.LineHost;
				if (lineHost2 == null)
				{
					return;
				}
				lineHost2.SetReason(season, show);
				return;
			}
		}

		// Token: 0x06042559 RID: 271705 RVA: 0x0101B5F3 File Offset: 0x010197F3
		public void ClearCombineFlyTween()
		{
			LguiFloatTween combineFlyTween = this.CombineFlyTween;
			if (combineFlyTween != null)
			{
				combineFlyTween.Destroy();
			}
			this.CombineFlyTween = null;
		}

		// Token: 0x0604255A RID: 271706 RVA: 0x0101B610 File Offset: 0x01019810
		public UniTask PlayCombineSubAsync(FVector fxTargetAbs)
		{
			DangoBrawlPnlBagItemView.<PlayCombineSubAsync>d__60 <PlayCombineSubAsync>d__;
			<PlayCombineSubAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCombineSubAsync>d__.<>4__this = this;
			<PlayCombineSubAsync>d__.fxTargetAbs = fxTargetAbs;
			<PlayCombineSubAsync>d__.<>1__state = -1;
			<PlayCombineSubAsync>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<PlayCombineSubAsync>d__60>(ref <PlayCombineSubAsync>d__);
			return <PlayCombineSubAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604255B RID: 271707 RVA: 0x0101B65C File Offset: 0x0101985C
		public UniTask PlayCombineMainAsync()
		{
			DangoBrawlPnlBagItemView.<PlayCombineMainAsync>d__61 <PlayCombineMainAsync>d__;
			<PlayCombineMainAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCombineMainAsync>d__.<>4__this = this;
			<PlayCombineMainAsync>d__.<>1__state = -1;
			<PlayCombineMainAsync>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<PlayCombineMainAsync>d__61>(ref <PlayCombineMainAsync>d__);
			return <PlayCombineMainAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604255C RID: 271708 RVA: 0x0101B6A0 File Offset: 0x010198A0
		public UniTask PlayCombineFinishAsync()
		{
			DangoBrawlPnlBagItemView.<PlayCombineFinishAsync>d__62 <PlayCombineFinishAsync>d__;
			<PlayCombineFinishAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCombineFinishAsync>d__.<>4__this = this;
			<PlayCombineFinishAsync>d__.<>1__state = -1;
			<PlayCombineFinishAsync>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<PlayCombineFinishAsync>d__62>(ref <PlayCombineFinishAsync>d__);
			return <PlayCombineFinishAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604255D RID: 271709 RVA: 0x0101B6E4 File Offset: 0x010198E4
		public FVector GetCombineFxAbsPos()
		{
			UUIItem rootItem = this.RootItem;
			FVector fvector = (rootItem != null) ? rootItem.GetLGUISpaceAbsolutePosition() : new FVector(0f, 0f, 0f);
			UUIItem rootItem2 = this.RootItem;
			float num = ((rootItem2 != null) ? rootItem2.GetWidth() : 0f) * 0.5f;
			UUIItem rootItem3 = this.RootItem;
			float num2 = ((rootItem3 != null) ? rootItem3.GetHeight() : 0f) * 0.5f;
			return new FVector(fvector.X + num, fvector.Y - num2, 0f);
		}

		// Token: 0x0604255E RID: 271710 RVA: 0x0101B76B File Offset: 0x0101996B
		public int GetOwnerUid()
		{
			return base.MyUid;
		}

		// Token: 0x0604255F RID: 271711 RVA: 0x0101B773 File Offset: 0x01019973
		public int GetOwnerConfigId()
		{
			return base.MyConfigId;
		}

		// Token: 0x06042560 RID: 271712 RVA: 0x0101B77B File Offset: 0x0101997B
		public UUIItem GetOwnerRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x06042561 RID: 271713 RVA: 0x0101B783 File Offset: 0x01019983
		public void NotifyAsPartner(int requesterUid, bool show)
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.SetPartnerReason(requesterUid, show);
		}

		// Token: 0x06042562 RID: 271714 RVA: 0x0101B797 File Offset: 0x01019997
		public void RefreshLineAngles()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.RefreshAngles();
		}

		// Token: 0x04022988 RID: 141704
		private DangoBrawlPnlBagItemView.EStarShowReason StarReasons;

		// Token: 0x04022989 RID: 141705
		[Nullable(1)]
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x0402298A RID: 141706
		private DangoBrawlViewCost WeightPanel;

		// Token: 0x0402298B RID: 141707
		private DangoBrawlCombineGuideLineHost LineHost;

		// Token: 0x0402298C RID: 141708
		private LguiFloatTween CombineFlyTween;

		// Token: 0x0200C948 RID: 51528
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CC53 RID: 248915
			ContentStar = 9,
			// Token: 0x0403CC54 RID: 248916
			TemplateStar,
			// Token: 0x0403CC55 RID: 248917
			ItemCost,
			// Token: 0x0403CC56 RID: 248918
			ContentBlurGrid,
			// Token: 0x0403CC57 RID: 248919
			TemplateBlurGrid,
			// Token: 0x0403CC58 RID: 248920
			ContentLine,
			// Token: 0x0403CC59 RID: 248921
			TemplateLine,
			// Token: 0x0403CC5A RID: 248922
			PnlVfx,
			// Token: 0x0403CC5B RID: 248923
			PnlUniqueWeapon,
			// Token: 0x0403CC5C RID: 248924
			SprIconMask02,
			// Token: 0x0403CC5D RID: 248925
			ItemCombinFx,
			// Token: 0x0403CC5E RID: 248926
			FxNiagaraType1 = 21,
			// Token: 0x0403CC5F RID: 248927
			FxNiagaraType2,
			// Token: 0x0403CC60 RID: 248928
			PnlMobileSwitch,
			// Token: 0x0403CC61 RID: 248929
			SprIconMask03,
			// Token: 0x0403CC62 RID: 248930
			ItemBenchDropFx,
			// Token: 0x0403CC63 RID: 248931
			NiagaraQualityFx
		}

		// Token: 0x0200C949 RID: 51529
		[NullableContext(0)]
		[Flags]
		private enum EStarShowReason
		{
			// Token: 0x0403CC65 RID: 248933
			None = 0,
			// Token: 0x0403CC66 RID: 248934
			Selected = 1,
			// Token: 0x0403CC67 RID: 248935
			Drag = 2,
			// Token: 0x0403CC68 RID: 248936
			Hover = 4,
			// Token: 0x0403CC69 RID: 248937
			Activating = 8
		}
	}
}
