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
	// Token: 0x02005743 RID: 22339
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlBagItemView : DangoBrawlViewItemBase, ICombineLineOwner
	{
		// Token: 0x17006A4D RID: 27213
		// (get) Token: 0x0603707F RID: 225407 RVA: 0x00F5BF72 File Offset: 0x00F5A172
		private DangoBrawlBackpackItemData BagItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x17006A4E RID: 27214
		// (get) Token: 0x06037080 RID: 225408 RVA: 0x00F5BF7F File Offset: 0x00F5A17F
		private DangoBrawlBenchItemData BenchItemData
		{
			get
			{
				return this.ItemData as DangoBrawlBenchItemData;
			}
		}

		// Token: 0x17006A4F RID: 27215
		// (get) Token: 0x06037081 RID: 225409 RVA: 0x00F5BF8C File Offset: 0x00F5A18C
		private DangoBrawlDataController DataController
		{
			get
			{
				return DangoBrawlModel.Instance.GetDataController();
			}
		}

		// Token: 0x17006A50 RID: 27216
		// (get) Token: 0x06037082 RID: 225410 RVA: 0x00F5BF98 File Offset: 0x00F5A198
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(18);
			}
		}

		// Token: 0x17006A51 RID: 27217
		// (get) Token: 0x06037083 RID: 225411 RVA: 0x00F5BFA2 File Offset: 0x00F5A1A2
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(24);
			}
		}

		// Token: 0x06037084 RID: 225412 RVA: 0x00F5BFAC File Offset: 0x00F5A1AC
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

		// Token: 0x06037085 RID: 225413 RVA: 0x00F5BFD4 File Offset: 0x00F5A1D4
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

		// Token: 0x06037086 RID: 225414 RVA: 0x00F5C170 File Offset: 0x00F5A370
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlBagItemView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037087 RID: 225415 RVA: 0x00F5C1B3 File Offset: 0x00F5A3B3
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

		// Token: 0x06037088 RID: 225416 RVA: 0x00F5C1EC File Offset: 0x00F5A3EC
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
		}

		// Token: 0x06037089 RID: 225417 RVA: 0x00F5C250 File Offset: 0x00F5A450
		private void UnBindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
		}

		// Token: 0x0603708A RID: 225418 RVA: 0x00F5C2B4 File Offset: 0x00F5A4B4
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

		// Token: 0x0603708B RID: 225419 RVA: 0x00F5C31B File Offset: 0x00F5A51B
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

		// Token: 0x0603708C RID: 225420 RVA: 0x00F5C34C File Offset: 0x00F5A54C
		protected override void RefreshRotation(EDangoBrawlRotate val)
		{
			this.RefreshPosFromRotate(val);
			this.RefreshStarsView(val);
		}

		// Token: 0x0603708D RID: 225421 RVA: 0x00F5C35C File Offset: 0x00F5A55C
		public override void SetSelectedVisualState(bool enable)
		{
			base.SetSelectedVisualState(enable);
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Selected, enable);
		}

		// Token: 0x0603708E RID: 225422 RVA: 0x00F5C36D File Offset: 0x00F5A56D
		private void InitFxScale()
		{
			UUIItem item = base.GetItem(25);
			if (item == null)
			{
				return;
			}
			item.SetRelativeScale3D(DangoBrawlUtil.GetFxScale(this.ItemData.MyConfigId, EDangoBrawlRotate.Direction0));
		}

		// Token: 0x0603708F RID: 225423 RVA: 0x00F5C394 File Offset: 0x00F5A594
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

		// Token: 0x06037090 RID: 225424 RVA: 0x00F5C41D File Offset: 0x00F5A61D
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

		// Token: 0x06037091 RID: 225425 RVA: 0x00F5C45C File Offset: 0x00F5A65C
		public void PlayItemActiveSeq()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Activate", false, null);
		}

		// Token: 0x06037092 RID: 225426 RVA: 0x00F5C488 File Offset: 0x00F5A688
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x06037093 RID: 225427 RVA: 0x00F5C490 File Offset: 0x00F5A690
		private void OnItemHoveredChange(int uid, EDragSourceKind source)
		{
			this.RefreshMobileTips();
		}

		// Token: 0x06037094 RID: 225428 RVA: 0x00F5C498 File Offset: 0x00F5A698
		public override void OnDragSourceBegin()
		{
			base.OnDragSourceBegin();
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Drag, true);
			this.SetCombineGuideLineReason(ECombineLineShowReason.Drag, true);
			this.RefreshMobileTips();
		}

		// Token: 0x06037095 RID: 225429 RVA: 0x00F5C4B6 File Offset: 0x00F5A6B6
		public override void OnDragSourceEnd()
		{
			base.OnDragSourceEnd();
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Drag, false);
			this.SetCombineGuideLineReason(ECombineLineShowReason.Drag, false);
			this.RefreshMobileTips();
		}

		// Token: 0x06037096 RID: 225430 RVA: 0x00F5C4D4 File Offset: 0x00F5A6D4
		public override void OnMoving()
		{
			base.OnMoving();
			this.RefreshCombineLineAngles();
			this.RefreshStarFillByWorldPos();
		}

		// Token: 0x06037097 RID: 225431 RVA: 0x00F5C4E8 File Offset: 0x00F5A6E8
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

		// Token: 0x06037098 RID: 225432 RVA: 0x00F5C55C File Offset: 0x00F5A75C
		protected override void OnPointerExit(EToggleState _)
		{
			base.OnPointerExit(_);
			this.SetStarActiveReason(DangoBrawlPnlBagItemView.EStarShowReason.Hover, false);
			this.SetCombineGuideLineReason(ECombineLineShowReason.Hover, false);
		}

		// Token: 0x06037099 RID: 225433 RVA: 0x00F5C575 File Offset: 0x00F5A775
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

		// Token: 0x0603709A RID: 225434 RVA: 0x00F5C59C File Offset: 0x00F5A79C
		private void RefreshBagPosition()
		{
			if (this.BagItemData == null || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			PanelPos myLeftTopPos = this.BagItemData.MyLeftTopPos;
			this.RootItem.SetUIRelativeLocation(new FVector((float)(myLeftTopPos.ColIndex * this.GridSize), (float)(-(float)myLeftTopPos.RowIndex * this.GridSize), 0f));
		}

		// Token: 0x0603709B RID: 225435 RVA: 0x00F5C608 File Offset: 0x00F5A808
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

		// Token: 0x0603709C RID: 225436 RVA: 0x00F5C654 File Offset: 0x00F5A854
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

		// Token: 0x0603709D RID: 225437 RVA: 0x00F5C68C File Offset: 0x00F5A88C
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

		// Token: 0x0603709E RID: 225438 RVA: 0x00F5C708 File Offset: 0x00F5A908
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

		// Token: 0x0603709F RID: 225439 RVA: 0x00F5C74C File Offset: 0x00F5A94C
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

		// Token: 0x060370A0 RID: 225440 RVA: 0x00F5C784 File Offset: 0x00F5A984
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

		// Token: 0x060370A1 RID: 225441 RVA: 0x00F5C7EC File Offset: 0x00F5A9EC
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

		// Token: 0x060370A2 RID: 225442 RVA: 0x00F5C838 File Offset: 0x00F5AA38
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

		// Token: 0x060370A3 RID: 225443 RVA: 0x00F5C883 File Offset: 0x00F5AA83
		private void RefreshStarFillByWorldPos()
		{
			IReadOnlyList<DangoBrawlGeneralStar> starPanels = this.StarPanels;
			DangoBrawlTouchController touch = base.Touch;
			DangoBrawlStarUtil.RefreshStarFillByWorldPos(starPanels, (touch != null) ? touch.GetBagDropZoneExtra() : null, this.ActData, base.MyUid);
		}

		// Token: 0x060370A4 RID: 225444 RVA: 0x00F5C8B0 File Offset: 0x00F5AAB0
		private UniTask CreateCostPanel()
		{
			DangoBrawlPnlBagItemView.<CreateCostPanel>d__49 <CreateCostPanel>d__;
			<CreateCostPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCostPanel>d__.<>4__this = this;
			<CreateCostPanel>d__.<>1__state = -1;
			<CreateCostPanel>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<CreateCostPanel>d__49>(ref <CreateCostPanel>d__);
			return <CreateCostPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060370A5 RID: 225445 RVA: 0x00F5C8F3 File Offset: 0x00F5AAF3
		public UUIItem GetWeightRootItem()
		{
			return base.GetItem(11);
		}

		// Token: 0x060370A6 RID: 225446 RVA: 0x00F5C900 File Offset: 0x00F5AB00
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

		// Token: 0x060370A7 RID: 225447 RVA: 0x00F5C96C File Offset: 0x00F5AB6C
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

		// Token: 0x060370A8 RID: 225448 RVA: 0x00F5C9C4 File Offset: 0x00F5ABC4
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

		// Token: 0x060370A9 RID: 225449 RVA: 0x00F5CA18 File Offset: 0x00F5AC18
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

		// Token: 0x060370AA RID: 225450 RVA: 0x00F5CAC7 File Offset: 0x00F5ACC7
		private void ClearCombineLines()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost != null)
			{
				lineHost.Destroy();
			}
			this.LineHost = null;
		}

		// Token: 0x060370AB RID: 225451 RVA: 0x00F5CAE1 File Offset: 0x00F5ACE1
		public void RefreshCombineLineAngles()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.RefreshAnglesAndPartners();
		}

		// Token: 0x060370AC RID: 225452 RVA: 0x00F5CAF3 File Offset: 0x00F5ACF3
		public void RebuildCombineGuideLinesIfShowing()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.RebuildShowing();
		}

		// Token: 0x060370AD RID: 225453 RVA: 0x00F5CB05 File Offset: 0x00F5AD05
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

		// Token: 0x060370AE RID: 225454 RVA: 0x00F5CB37 File Offset: 0x00F5AD37
		public void ClearCombineFlyTween()
		{
			LguiFloatTween combineFlyTween = this.CombineFlyTween;
			if (combineFlyTween != null)
			{
				combineFlyTween.Destroy();
			}
			this.CombineFlyTween = null;
		}

		// Token: 0x060370AF RID: 225455 RVA: 0x00F5CB54 File Offset: 0x00F5AD54
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

		// Token: 0x060370B0 RID: 225456 RVA: 0x00F5CBA0 File Offset: 0x00F5ADA0
		public UniTask PlayCombineMainAsync()
		{
			DangoBrawlPnlBagItemView.<PlayCombineMainAsync>d__61 <PlayCombineMainAsync>d__;
			<PlayCombineMainAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCombineMainAsync>d__.<>4__this = this;
			<PlayCombineMainAsync>d__.<>1__state = -1;
			<PlayCombineMainAsync>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<PlayCombineMainAsync>d__61>(ref <PlayCombineMainAsync>d__);
			return <PlayCombineMainAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060370B1 RID: 225457 RVA: 0x00F5CBE4 File Offset: 0x00F5ADE4
		public UniTask PlayCombineFinishAsync()
		{
			DangoBrawlPnlBagItemView.<PlayCombineFinishAsync>d__62 <PlayCombineFinishAsync>d__;
			<PlayCombineFinishAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCombineFinishAsync>d__.<>4__this = this;
			<PlayCombineFinishAsync>d__.<>1__state = -1;
			<PlayCombineFinishAsync>d__.<>t__builder.Start<DangoBrawlPnlBagItemView.<PlayCombineFinishAsync>d__62>(ref <PlayCombineFinishAsync>d__);
			return <PlayCombineFinishAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060370B2 RID: 225458 RVA: 0x00F5CC28 File Offset: 0x00F5AE28
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

		// Token: 0x060370B3 RID: 225459 RVA: 0x00F5CCAF File Offset: 0x00F5AEAF
		public int GetOwnerUid()
		{
			return base.MyUid;
		}

		// Token: 0x060370B4 RID: 225460 RVA: 0x00F5CCB7 File Offset: 0x00F5AEB7
		public int GetOwnerConfigId()
		{
			return base.MyConfigId;
		}

		// Token: 0x060370B5 RID: 225461 RVA: 0x00F5CCBF File Offset: 0x00F5AEBF
		public UUIItem GetOwnerRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x060370B6 RID: 225462 RVA: 0x00F5CCC7 File Offset: 0x00F5AEC7
		public void NotifyAsPartner(int requesterUid, bool show)
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.SetPartnerReason(requesterUid, show);
		}

		// Token: 0x060370B7 RID: 225463 RVA: 0x00F5CCDB File Offset: 0x00F5AEDB
		public void RefreshLineAngles()
		{
			DangoBrawlCombineGuideLineHost lineHost = this.LineHost;
			if (lineHost == null)
			{
				return;
			}
			lineHost.RefreshAngles();
		}

		// Token: 0x0401D1E5 RID: 119269
		private DangoBrawlPnlBagItemView.EStarShowReason StarReasons;

		// Token: 0x0401D1E6 RID: 119270
		[Nullable(1)]
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x0401D1E7 RID: 119271
		private DangoBrawlViewCost WeightPanel;

		// Token: 0x0401D1E8 RID: 119272
		private DangoBrawlCombineGuideLineHost LineHost;

		// Token: 0x0401D1E9 RID: 119273
		private LguiFloatTween CombineFlyTween;

		// Token: 0x0200B315 RID: 45845
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037540 RID: 226624
			ContentStar = 9,
			// Token: 0x04037541 RID: 226625
			TemplateStar,
			// Token: 0x04037542 RID: 226626
			ItemCost,
			// Token: 0x04037543 RID: 226627
			ContentBlurGrid,
			// Token: 0x04037544 RID: 226628
			TemplateBlurGrid,
			// Token: 0x04037545 RID: 226629
			ContentLine,
			// Token: 0x04037546 RID: 226630
			TemplateLine,
			// Token: 0x04037547 RID: 226631
			PnlVfx,
			// Token: 0x04037548 RID: 226632
			PnlUniqueWeapon,
			// Token: 0x04037549 RID: 226633
			SprIconMask02,
			// Token: 0x0403754A RID: 226634
			ItemCombinFx,
			// Token: 0x0403754B RID: 226635
			FxNiagaraType1 = 21,
			// Token: 0x0403754C RID: 226636
			FxNiagaraType2,
			// Token: 0x0403754D RID: 226637
			PnlMobileSwitch,
			// Token: 0x0403754E RID: 226638
			SprIconMask03,
			// Token: 0x0403754F RID: 226639
			ItemBenchDropFx,
			// Token: 0x04037550 RID: 226640
			NiagaraQualityFx
		}

		// Token: 0x0200B316 RID: 45846
		[NullableContext(0)]
		[Flags]
		private enum EStarShowReason
		{
			// Token: 0x04037552 RID: 226642
			None = 0,
			// Token: 0x04037553 RID: 226643
			Selected = 1,
			// Token: 0x04037554 RID: 226644
			Drag = 2,
			// Token: 0x04037555 RID: 226645
			Hover = 4,
			// Token: 0x04037556 RID: 226646
			Activating = 8
		}
	}
}
