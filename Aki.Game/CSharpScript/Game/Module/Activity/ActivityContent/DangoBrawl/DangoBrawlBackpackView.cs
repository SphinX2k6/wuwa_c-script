using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067E6 RID: 26598
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBackpackView : UiTickViewBase
	{
		// Token: 0x170096F9 RID: 38649
		// (get) Token: 0x060423CA RID: 271306 RVA: 0x01012764 File Offset: 0x01010964
		private bool IsLayerMode
		{
			get
			{
				DangoBrawlDataController dataController = DangoBrawlModel.Instance.GetDataController();
				return dataController != null && dataController.GetViewLayerMode();
			}
		}

		// Token: 0x170096FA RID: 38650
		// (get) Token: 0x060423CB RID: 271307 RVA: 0x0101277B File Offset: 0x0101097B
		private bool IsInteracting
		{
			get
			{
				DangoBrawlTouchController touch = this.Touch;
				if (touch == null || !touch.IsDragging)
				{
					DangoBrawlTouchController touch2 = this.Touch;
					return touch2 != null && touch2.IsFsmBlocking;
				}
				return true;
			}
		}

		// Token: 0x170096FB RID: 38651
		// (get) Token: 0x060423CC RID: 271308 RVA: 0x010127A4 File Offset: 0x010109A4
		private IDangoBrawlItemZone BagZone
		{
			get
			{
				return this.BackpackPanel;
			}
		}

		// Token: 0x170096FC RID: 38652
		// (get) Token: 0x060423CD RID: 271309 RVA: 0x010127AC File Offset: 0x010109AC
		private IDangoBrawlItemZone BenchZone
		{
			get
			{
				return this.BenchPanel;
			}
		}

		// Token: 0x170096FD RID: 38653
		// (get) Token: 0x060423CE RID: 271310 RVA: 0x010127B4 File Offset: 0x010109B4
		private UUIItem PnlTop
		{
			get
			{
				return base.GetItem(4);
			}
		}

		// Token: 0x170096FE RID: 38654
		// (get) Token: 0x060423CF RID: 271311 RVA: 0x010127BD File Offset: 0x010109BD
		private UUIItem PnlDragRoot
		{
			get
			{
				return base.GetItem(20);
			}
		}

		// Token: 0x170096FF RID: 38655
		// (get) Token: 0x060423D0 RID: 271312 RVA: 0x010127C7 File Offset: 0x010109C7
		private UUIExtendToggle TogLayer
		{
			get
			{
				return base.GetExtendToggle(7);
			}
		}

		// Token: 0x17009700 RID: 38656
		// (get) Token: 0x060423D1 RID: 271313 RVA: 0x010127D0 File Offset: 0x010109D0
		private UUIButtonComponent BtnChooseRecover
		{
			get
			{
				return base.GetButton(36);
			}
		}

		// Token: 0x17009701 RID: 38657
		// (get) Token: 0x060423D2 RID: 271314 RVA: 0x010127DA File Offset: 0x010109DA
		private DangoBrawlItemViewRegistry ViewRegistry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x17009702 RID: 38658
		// (get) Token: 0x060423D3 RID: 271315 RVA: 0x010127E6 File Offset: 0x010109E6
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17009703 RID: 38659
		// (get) Token: 0x060423D4 RID: 271316 RVA: 0x010127F2 File Offset: 0x010109F2
		private IInteractionMode Layer
		{
			get
			{
				DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
				if (touchController == null)
				{
					return null;
				}
				return touchController.GetLayerMode();
			}
		}

		// Token: 0x060423D5 RID: 271317 RVA: 0x01012809 File Offset: 0x01010A09
		[NullableContext(1)]
		public DangoBrawlBackpackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060423D6 RID: 271318 RVA: 0x01012814 File Offset: 0x01010A14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 37;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickLevelDetail));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickCollection));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnToggleLayer));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnMaskBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(36, new Action(this.OnChooseRevoverBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060423D7 RID: 271319 RVA: 0x01012DE8 File Offset: 0x01010FE8
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBackpackView.<OnBeforeStartAsync>d__55 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBackpackView.<OnBeforeStartAsync>d__55>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060423D8 RID: 271320 RVA: 0x01012E2B File Offset: 0x0101102B
		protected override void OnStart()
		{
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			if (viewRegistry != null)
			{
				viewRegistry.RegisterBackpackView(this);
			}
			this.InitWeightView();
			this.InitHpDeltaView();
			this.RefreshEventInfoPanel().Forget();
			this.RefreshOptionButtons();
		}

		// Token: 0x060423D9 RID: 271321 RVA: 0x01012E5C File Offset: 0x0101105C
		protected override void OnBeforeShow()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, true, true, 0);
		}

		// Token: 0x060423DA RID: 271322 RVA: 0x01012E79 File Offset: 0x01011079
		protected override void OnBeforeHide()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, false, true, 0);
		}

		// Token: 0x060423DB RID: 271323 RVA: 0x01012E98 File Offset: 0x01011098
		protected override void OnBeforeDestroy()
		{
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			if (viewRegistry != null)
			{
				viewRegistry.UnregisterBackpackView(this);
			}
			this.UnBindEvents();
			this.CancelHoverTipsHideTimer();
			this.CancelLoadRoleSpine();
			this.ClearTalkController();
			this.ClearSequencePlayer();
			this.ClearOptionProxy();
			this.ClearHotKeyProxy();
			this.UnwireTouchController();
		}

		// Token: 0x060423DC RID: 271324 RVA: 0x01012EE8 File Offset: 0x010110E8
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragWillBegin, new Action<EDragSourceKind, int>(this.OnDragWillBegin));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragEndAnyWay, new Action(this.OnDragEndAnyWay));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnLayerModeChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnDangoBrawlBagOperated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnShopComposed));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlFighterAttrChanged, new Action(this.OnFighterAttrChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlActiveEventsUpdated, new Action(this.OnActiveEventsUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlThreeChooseClosed, new Action(this.OnThreeChooseClosed));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlRoundStartEffectsReady, new Action(this.OnRoundStartEffectsReady));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlThreeChooseStateChanged, new Action<bool>(this.OnDangoBrawlChooseUiStateChanged));
		}

		// Token: 0x060423DD RID: 271325 RVA: 0x010130D4 File Offset: 0x010112D4
		private void UnBindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragWillBegin, new Action<EDragSourceKind, int>(this.OnDragWillBegin));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragEndAnyWay, new Action(this.OnDragEndAnyWay));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnLayerModeChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnDangoBrawlBagOperated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnShopComposed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlFighterAttrChanged, new Action(this.OnFighterAttrChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlActiveEventsUpdated, new Action(this.OnActiveEventsUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlThreeChooseClosed, new Action(this.OnThreeChooseClosed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlRoundStartEffectsReady, new Action(this.OnRoundStartEffectsReady));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlThreeChooseStateChanged, new Action<bool>(this.OnDangoBrawlChooseUiStateChanged));
		}

		// Token: 0x060423DE RID: 271326 RVA: 0x010132BD File Offset: 0x010114BD
		public UUIItem GetBenchHitItem()
		{
			DangoBrawlPnlBench benchPanel = this.BenchPanel;
			if (benchPanel == null)
			{
				return null;
			}
			return benchPanel.HitItem;
		}

		// Token: 0x060423DF RID: 271327 RVA: 0x010132D0 File Offset: 0x010114D0
		public UUIItem GetBagHitItem()
		{
			DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return null;
			}
			return backpackPanel.HitItem;
		}

		// Token: 0x060423E0 RID: 271328 RVA: 0x010132E3 File Offset: 0x010114E3
		public UUIItem GetShopHitItem()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return null;
			}
			return shopPanel.HitItem;
		}

		// Token: 0x060423E1 RID: 271329 RVA: 0x010132F8 File Offset: 0x010114F8
		private UniTask CreateFightPanel()
		{
			DangoBrawlBackpackView.<CreateFightPanel>d__65 <CreateFightPanel>d__;
			<CreateFightPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFightPanel>d__.<>4__this = this;
			<CreateFightPanel>d__.<>1__state = -1;
			<CreateFightPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateFightPanel>d__65>(ref <CreateFightPanel>d__);
			return <CreateFightPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060423E2 RID: 271330 RVA: 0x0101333C File Offset: 0x0101153C
		private UniTask CreateShopPanel()
		{
			DangoBrawlBackpackView.<CreateShopPanel>d__66 <CreateShopPanel>d__;
			<CreateShopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateShopPanel>d__.<>4__this = this;
			<CreateShopPanel>d__.<>1__state = -1;
			<CreateShopPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateShopPanel>d__66>(ref <CreateShopPanel>d__);
			return <CreateShopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060423E3 RID: 271331 RVA: 0x01013380 File Offset: 0x01011580
		private UniTask CreateBenchPanel()
		{
			DangoBrawlBackpackView.<CreateBenchPanel>d__67 <CreateBenchPanel>d__;
			<CreateBenchPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBenchPanel>d__.<>4__this = this;
			<CreateBenchPanel>d__.<>1__state = -1;
			<CreateBenchPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateBenchPanel>d__67>(ref <CreateBenchPanel>d__);
			return <CreateBenchPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060423E4 RID: 271332 RVA: 0x010133C4 File Offset: 0x010115C4
		public UniTask CreateBackpackPanel()
		{
			DangoBrawlBackpackView.<CreateBackpackPanel>d__68 <CreateBackpackPanel>d__;
			<CreateBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBackpackPanel>d__.<>4__this = this;
			<CreateBackpackPanel>d__.<>1__state = -1;
			<CreateBackpackPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateBackpackPanel>d__68>(ref <CreateBackpackPanel>d__);
			return <CreateBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060423E5 RID: 271333 RVA: 0x01013408 File Offset: 0x01011608
		public UniTask CreateItemTips()
		{
			DangoBrawlBackpackView.<CreateItemTips>d__69 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateItemTips>d__69>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x060423E6 RID: 271334 RVA: 0x0101344C File Offset: 0x0101164C
		private UniTask CreateAchievementTips()
		{
			DangoBrawlBackpackView.<CreateAchievementTips>d__70 <CreateAchievementTips>d__;
			<CreateAchievementTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAchievementTips>d__.<>4__this = this;
			<CreateAchievementTips>d__.<>1__state = -1;
			<CreateAchievementTips>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateAchievementTips>d__70>(ref <CreateAchievementTips>d__);
			return <CreateAchievementTips>d__.<>t__builder.Task;
		}

		// Token: 0x060423E7 RID: 271335 RVA: 0x01013490 File Offset: 0x01011690
		private UniTask CreateEventInfoPanel()
		{
			DangoBrawlBackpackView.<CreateEventInfoPanel>d__71 <CreateEventInfoPanel>d__;
			<CreateEventInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateEventInfoPanel>d__.<>4__this = this;
			<CreateEventInfoPanel>d__.<>1__state = -1;
			<CreateEventInfoPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateEventInfoPanel>d__71>(ref <CreateEventInfoPanel>d__);
			return <CreateEventInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060423E8 RID: 271336 RVA: 0x010134D4 File Offset: 0x010116D4
		private UniTask CreateCaptionItem()
		{
			DangoBrawlBackpackView.<CreateCaptionItem>d__72 <CreateCaptionItem>d__;
			<CreateCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionItem>d__.<>4__this = this;
			<CreateCaptionItem>d__.<>1__state = -1;
			<CreateCaptionItem>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateCaptionItem>d__72>(ref <CreateCaptionItem>d__);
			return <CreateCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x060423E9 RID: 271337 RVA: 0x01013518 File Offset: 0x01011718
		private UniTask CreateOccupationBtnItem()
		{
			DangoBrawlBackpackView.<CreateOccupationBtnItem>d__73 <CreateOccupationBtnItem>d__;
			<CreateOccupationBtnItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateOccupationBtnItem>d__.<>4__this = this;
			<CreateOccupationBtnItem>d__.<>1__state = -1;
			<CreateOccupationBtnItem>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateOccupationBtnItem>d__73>(ref <CreateOccupationBtnItem>d__);
			return <CreateOccupationBtnItem>d__.<>t__builder.Task;
		}

		// Token: 0x060423EA RID: 271338 RVA: 0x0101355B File Offset: 0x0101175B
		private void CreateHotKeyProxy()
		{
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null && touch.GetInputPlatform() == EInputPlatform.Mobile)
			{
				return;
			}
			this.HotKeyProxy = new DangoBrawlBackpackHotKeyProxy(base.GetItem(31));
			this.HotKeyProxy.Start();
		}

		// Token: 0x060423EB RID: 271339 RVA: 0x01013594 File Offset: 0x01011794
		public UniTask CreateRoleSpine()
		{
			DangoBrawlBackpackView.<CreateRoleSpine>d__75 <CreateRoleSpine>d__;
			<CreateRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRoleSpine>d__.<>4__this = this;
			<CreateRoleSpine>d__.<>1__state = -1;
			<CreateRoleSpine>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateRoleSpine>d__75>(ref <CreateRoleSpine>d__);
			return <CreateRoleSpine>d__.<>t__builder.Task;
		}

		// Token: 0x060423EC RID: 271340 RVA: 0x010135D7 File Offset: 0x010117D7
		public void CancelLoadRoleSpine()
		{
			if (this.SpineAtlasPromise != null)
			{
				this.SpineAtlasPromise.CancelAsyncLoad();
				this.SpineAtlasPromise = null;
			}
			if (this.SpineSkeletonPromise != null)
			{
				this.SpineSkeletonPromise.CancelAsyncLoad();
				this.SpineSkeletonPromise = null;
			}
		}

		// Token: 0x060423ED RID: 271341 RVA: 0x01013610 File Offset: 0x01011810
		private void CreateSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
			this.SequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnStartSequenceEvent));
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
			this.HpTween = new LguiFloatTween();
			this.HpTween.SetCurrentEase(LTweenEase.InOutSine);
			this.HpTween.BindUpdateTween(new Action<float>(this.OnHpTweenUpdate));
		}

		// Token: 0x060423EE RID: 271342 RVA: 0x01013698 File Offset: 0x01011898
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			LguiFloatTween hpTween = this.HpTween;
			if (hpTween != null)
			{
				hpTween.Destroy();
			}
			this.HpTween = null;
			LguiFloatTween eventFlyTween = this.EventFlyTween;
			if (eventFlyTween != null)
			{
				eventFlyTween.Destroy();
			}
			this.EventFlyTween = null;
		}

		// Token: 0x060423EF RID: 271343 RVA: 0x010136F0 File Offset: 0x010118F0
		private void CreateTalkController()
		{
			this.ClearTalkController();
			this.TalkController = new DangoBrawlBackpackTalkController();
			DangoBrawlBackpackTalkController talkController = this.TalkController;
			ActivityDangoBrawlData actData = this.ActData;
			UUIItem item = base.GetItem(9);
			UUIText text = base.GetText(10);
			DangoBrawlInstBaseNotify instBase = this.ActData.InstBase;
			talkController.Init(actData, item, text, (instBase != null) ? instBase.RoleId : 0, this.SequencePlayer, base.GetSpine(8));
		}

		// Token: 0x060423F0 RID: 271344 RVA: 0x01013753 File Offset: 0x01011953
		private void ClearTalkController()
		{
			DangoBrawlBackpackTalkController talkController = this.TalkController;
			if (talkController != null)
			{
				talkController.Destroy();
			}
			this.TalkController = null;
		}

		// Token: 0x060423F1 RID: 271345 RVA: 0x01013770 File Offset: 0x01011970
		private void InitHpDeltaView()
		{
			int maxHpDelta = this.ActData.FightersServerData.GetMaxHpDelta();
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.UpdateHpView(this.ActData.MyFighterMaxHp - maxHpDelta, false);
			if (maxHpDelta > 0)
			{
				this.UpdateHpDeltaView(maxHpDelta);
			}
		}

		// Token: 0x060423F2 RID: 271346 RVA: 0x010137C1 File Offset: 0x010119C1
		private void InitWeightView()
		{
			this.IsOverweight = this.CalcOverweight();
		}

		// Token: 0x060423F3 RID: 271347 RVA: 0x010137D0 File Offset: 0x010119D0
		private void UpdateInteractiveVisual()
		{
			bool flag = this.IsInteracting || this.IsLayerMode;
			DangoBrawlBackpackFight fightPanel = this.FightPanel;
			if (fightPanel != null)
			{
				fightPanel.SetFightBtnInteractive(!flag);
			}
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel != null)
			{
				shopPanel.SetRefreshBtnInteractive(!flag);
			}
			DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return;
			}
			backpackPanel.SetCombineActive(!flag);
		}

		// Token: 0x060423F4 RID: 271348 RVA: 0x01013830 File Offset: 0x01011A30
		private void UpdateDragOtherDimView()
		{
			bool isInteracting = this.IsInteracting;
			IReadOnlySet<int> excludeUids = isInteracting ? this.CollectDraggingUids() : null;
			DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
			if (backpackPanel != null)
			{
				backpackPanel.SetDragOtherVisualState(isInteracting, excludeUids);
			}
			DangoBrawlPnlBench benchPanel = this.BenchPanel;
			if (benchPanel == null)
			{
				return;
			}
			benchPanel.SetDragOtherVisualState(isInteracting, excludeUids);
		}

		// Token: 0x060423F5 RID: 271349 RVA: 0x01013878 File Offset: 0x01011A78
		private void UpdateHpView(int hp, bool animate = false)
		{
			if (animate && this.DisplayedHp != hp)
			{
				LguiFloatTween hpTween = this.HpTween;
				if (hpTween != null)
				{
					hpTween.PlayTween((float)this.DisplayedHp, (float)hp, 0.35f, null);
				}
			}
			else
			{
				LguiFloatTween hpTween2 = this.HpTween;
				if (hpTween2 != null)
				{
					hpTween2.KillTween();
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "DangoBrawlBattleUIText_030", new <>z__ReadOnlySingleElementList<object>(hp));
			}
			this.DisplayedHp = hp;
		}

		// Token: 0x060423F6 RID: 271350 RVA: 0x010138F0 File Offset: 0x01011AF0
		private void UpdateHpDeltaView(int hpDelta)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "DangoBrawlBattleUIText_002", new <>z__ReadOnlySingleElementList<object>(hpDelta));
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(hpDelta > 0);
			}
			if (hpDelta > 0)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlaySequencePurely("HpStart", false, false);
			}
		}

		// Token: 0x060423F7 RID: 271351 RVA: 0x01013954 File Offset: 0x01011B54
		private void UpdateOverweightView()
		{
			bool flag = this.CalcOverweight();
			if (flag == this.IsOverweight)
			{
				return;
			}
			this.IsOverweight = flag;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely(flag ? "OverweightIn" : "OverweightOut", false, false);
		}

		// Token: 0x060423F8 RID: 271352 RVA: 0x0101399C File Offset: 0x01011B9C
		private void SetDragVisualState(bool active)
		{
			UUIItem pnlTop = this.PnlTop;
			if (pnlTop != null)
			{
				pnlTop.SetUIActive(!active);
			}
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetUiActive(!active);
			}
			UUIExtendToggle togLayer = this.TogLayer;
			if (togLayer != null)
			{
				UUIItem rootComponent = togLayer.GetRootComponent();
				if (rootComponent != null)
				{
					rootComponent.SetUIActive(!active);
				}
			}
			DangoBrawlBackpackOccupationBtnItem btnRoleOccupation = this.BtnRoleOccupation;
			if (btnRoleOccupation != null)
			{
				btnRoleOccupation.SetUiActive(!active);
			}
			this.UpdateInteractiveVisual();
			this.UpdateDragOtherDimView();
		}

		// Token: 0x060423F9 RID: 271353 RVA: 0x01013A14 File Offset: 0x01011C14
		private IReadOnlySet<int> CollectDraggingUids()
		{
			DangoBrawlTouchController touch = this.Touch;
			IDragVisual dragVisual;
			if ((dragVisual = ((touch != null) ? touch.DraggingVisual : null)) == null)
			{
				DangoBrawlTouchController touch2 = this.Touch;
				if (touch2 == null)
				{
					dragVisual = null;
				}
				else
				{
					InteractionPayload payLoad = touch2.GetInteractionFsm().GetPayLoad();
					dragVisual = ((payLoad != null) ? payLoad.Visual : null);
				}
			}
			IDragVisual dragVisual2 = dragVisual;
			if (dragVisual2 == null)
			{
				return null;
			}
			HashSet<int> hashSet = new HashSet<int>
			{
				dragVisual2.SourceUid
			};
			DragPayloadFollower[] followers = dragVisual2.Followers;
			for (int i = 0; i < followers.Length; i++)
			{
				int myUid = followers[i].View.MyUid;
				if (myUid > 0)
				{
					hashSet.Add(myUid);
				}
			}
			return hashSet;
		}

		// Token: 0x060423FA RID: 271354 RVA: 0x01013AA8 File Offset: 0x01011CA8
		private void WireTouchController()
		{
			if (this.Touch == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.LSH, "WireTouchController: TouchController 为空，商店交互将失效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Touch.SetDragLayer(this.PnlDragRoot);
			UUIItem item = base.GetItem(23);
			if (item != null)
			{
				DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
				if (viewRegistry != null)
				{
					viewRegistry.SetProxyTemplate(EDangoBrawlTemplateType.Bag, item);
				}
			}
			UUIItem item2 = base.GetItem(24);
			if (item2 != null)
			{
				DangoBrawlItemViewRegistry viewRegistry2 = this.ViewRegistry;
				if (viewRegistry2 != null)
				{
					viewRegistry2.SetProxyTemplate(EDangoBrawlTemplateType.Item, item2);
				}
			}
			UUIItem bagHitItem = this.GetBagHitItem();
			if (bagHitItem != null && this.BackpackPanel != null)
			{
				this.Touch.RegisterDropZone(new DangoBrawlDropZone
				{
					Kind = EDragTargetKind.Bag,
					HitItem = bagHitItem,
					BagExtra = this.BackpackPanel
				});
				DangoBrawlItemViewRegistry viewRegistry3 = this.ViewRegistry;
				if (viewRegistry3 != null)
				{
					viewRegistry3.RegisterItemZone(EDragTargetKind.Bag, this.BackpackPanel);
				}
			}
			UUIItem benchHitItem = this.GetBenchHitItem();
			if (this.BenchPanel != null && benchHitItem != null)
			{
				this.Touch.RegisterDropZone(new DangoBrawlDropZone
				{
					Kind = EDragTargetKind.Bench,
					HitItem = benchHitItem,
					BenchExtra = this.BenchPanel
				});
				DangoBrawlItemViewRegistry viewRegistry4 = this.ViewRegistry;
				if (viewRegistry4 != null)
				{
					viewRegistry4.RegisterItemZone(EDragTargetKind.Bench, this.BenchPanel);
				}
			}
			UUIItem shopHitItem = this.GetShopHitItem();
			if (shopHitItem != null)
			{
				this.Touch.RegisterDropZone(new DangoBrawlDropZone
				{
					Kind = EDragTargetKind.Shop,
					HitItem = shopHitItem
				});
			}
		}

		// Token: 0x060423FB RID: 271355 RVA: 0x01013C00 File Offset: 0x01011E00
		private void UnwireTouchController()
		{
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			if (viewRegistry != null)
			{
				viewRegistry.UnregisterItemZone(EDragTargetKind.Bench);
			}
			DangoBrawlItemViewRegistry viewRegistry2 = this.ViewRegistry;
			if (viewRegistry2 != null)
			{
				viewRegistry2.UnregisterItemZone(EDragTargetKind.Bag);
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null)
			{
				touch.UnregisterDropZone(EDragTargetKind.Bench);
			}
			DangoBrawlTouchController touch2 = this.Touch;
			if (touch2 != null)
			{
				touch2.UnregisterDropZone(EDragTargetKind.Bag);
			}
			DangoBrawlTouchController touch3 = this.Touch;
			if (touch3 != null)
			{
				touch3.UnregisterDropZone(EDragTargetKind.Shop);
			}
			DangoBrawlTouchController touch4 = this.Touch;
			if (touch4 == null)
			{
				return;
			}
			touch4.SetDragLayer(null);
		}

		// Token: 0x060423FC RID: 271356 RVA: 0x01013C78 File Offset: 0x01011E78
		private bool CalcOverweight()
		{
			DangoBrawlDataController dataController = DangoBrawlModel.Instance.GetDataController();
			int num = (dataController != null) ? dataController.GetDisplayCost() : 0;
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int num2 = (selfFighter != null) ? selfFighter.Cost : 0;
			return num > num2;
		}

		// Token: 0x060423FD RID: 271357 RVA: 0x01013CBC File Offset: 0x01011EBC
		private void SetSellPanelActive(bool active, int configId)
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel != null)
			{
				shopPanel.UpdateSellPanelInfo(configId);
			}
			if (active == this.IsSellPanelActive)
			{
				return;
			}
			this.IsSellPanelActive = active;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely(active ? "Grabsellin" : "GrabsellOut", false, false);
		}

		// Token: 0x060423FE RID: 271358 RVA: 0x01013D0D File Offset: 0x01011F0D
		private void ClearTipsReasonHover()
		{
			this.CancelHoverTipsHideTimer();
			this.HoverTipsUid = -1;
			this.SetTipsReason(DangoBrawlBackpackView.ETipsReason.Hover, false);
		}

		// Token: 0x060423FF RID: 271359 RVA: 0x01013D24 File Offset: 0x01011F24
		private void ScheduleClearTipsReasonHover()
		{
			this.CancelHoverTipsHideTimer();
			this.HoverTipsHideTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.HoverTipsHideTimer = null;
				this.HoverTipsUid = -1;
				this.SetTipsReason(DangoBrawlBackpackView.ETipsReason.Hover, false);
			}, 50f, null, null, true, 1f);
		}

		// Token: 0x06042400 RID: 271360 RVA: 0x01013D55 File Offset: 0x01011F55
		private void CancelHoverTipsHideTimer()
		{
			TimerHandle hoverTipsHideTimer = this.HoverTipsHideTimer;
			if (hoverTipsHideTimer != null)
			{
				hoverTipsHideTimer.Remove();
			}
			this.HoverTipsHideTimer = null;
		}

		// Token: 0x06042401 RID: 271361 RVA: 0x01013D70 File Offset: 0x01011F70
		[NullableContext(1)]
		private void TryEnterLayerMode(IInteractionMode ctrl)
		{
			if (!ctrl.TryEnter())
			{
				UUIExtendToggle togLayer = this.TogLayer;
				if (togLayer == null)
				{
					return;
				}
				togLayer.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06042402 RID: 271362 RVA: 0x01013D90 File Offset: 0x01011F90
		[NullableContext(1)]
		private UniTask TryExitLayerMode(IInteractionMode ctrl)
		{
			DangoBrawlBackpackView.<TryExitLayerMode>d__98 <TryExitLayerMode>d__;
			<TryExitLayerMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryExitLayerMode>d__.<>4__this = this;
			<TryExitLayerMode>d__.ctrl = ctrl;
			<TryExitLayerMode>d__.<>1__state = -1;
			<TryExitLayerMode>d__.<>t__builder.Start<DangoBrawlBackpackView.<TryExitLayerMode>d__98>(ref <TryExitLayerMode>d__);
			return <TryExitLayerMode>d__.<>t__builder.Task;
		}

		// Token: 0x06042403 RID: 271363 RVA: 0x01013DDB File Offset: 0x01011FDB
		public int BeginSellCoinHold()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return 0;
			}
			return shopPanel.BeginSellCoinHold();
		}

		// Token: 0x06042404 RID: 271364 RVA: 0x01013DEE File Offset: 0x01011FEE
		public int BeginGiveCoinHold()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return 0;
			}
			return shopPanel.BeginCoinHoldWithFlush();
		}

		// Token: 0x06042405 RID: 271365 RVA: 0x01013E01 File Offset: 0x01012001
		public void SetSellRaycastActive(bool active)
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return;
			}
			shopPanel.SetSellRaycastActive(active);
		}

		// Token: 0x06042406 RID: 271366 RVA: 0x01013E14 File Offset: 0x01012014
		public void CancelSell(int token)
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return;
			}
			shopPanel.EndSellCoinHold(token, false);
		}

		// Token: 0x06042407 RID: 271367 RVA: 0x01013E28 File Offset: 0x01012028
		public void FlushCoinHold(int token)
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return;
			}
			shopPanel.EndSellCoinHold(token, true);
		}

		// Token: 0x06042408 RID: 271368 RVA: 0x01013E3C File Offset: 0x0101203C
		public UUIItem GetShopGoldItem()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return null;
			}
			return shopPanel.GetGoldItem();
		}

		// Token: 0x06042409 RID: 271369 RVA: 0x01013E4F File Offset: 0x0101204F
		public UUIItem GetFirstCombineItemRootItem()
		{
			DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return null;
			}
			return backpackPanel.GetFirstCombineItemRootItem();
		}

		// Token: 0x0604240A RID: 271370 RVA: 0x01013E62 File Offset: 0x01012062
		public bool IsFightBtnInteractive()
		{
			DangoBrawlBackpackFight fightPanel = this.FightPanel;
			return fightPanel != null && fightPanel.IsFightBtnInteractive();
		}

		// Token: 0x0604240B RID: 271371 RVA: 0x01013E75 File Offset: 0x01012075
		public void ClickFightBtn()
		{
			DangoBrawlBackpackFight fightPanel = this.FightPanel;
			if (fightPanel == null)
			{
				return;
			}
			fightPanel.ClickFight();
		}

		// Token: 0x0604240C RID: 271372 RVA: 0x01013E88 File Offset: 0x01012088
		private void CreateOptionProxy()
		{
			this.OptionProxy = new DangoBrawlBackpackOptionProxy(this.ActData, base.GetItem(25), base.GetButton(26), base.GetButton(27), base.GetButton(28), base.GetButton(29), base.GetText(30));
			this.OptionProxy.Start();
		}

		// Token: 0x0604240D RID: 271373 RVA: 0x01013EE1 File Offset: 0x010120E1
		private void ClearOptionProxy()
		{
			DangoBrawlBackpackOptionProxy optionProxy = this.OptionProxy;
			if (optionProxy != null)
			{
				optionProxy.Destroy();
			}
			this.OptionProxy = null;
		}

		// Token: 0x0604240E RID: 271374 RVA: 0x01013EFB File Offset: 0x010120FB
		private void ClearHotKeyProxy()
		{
			DangoBrawlBackpackHotKeyProxy hotKeyProxy = this.HotKeyProxy;
			if (hotKeyProxy != null)
			{
				hotKeyProxy.Destroy();
			}
			this.HotKeyProxy = null;
		}

		// Token: 0x0604240F RID: 271375 RVA: 0x01013F15 File Offset: 0x01012115
		private void RefreshOptionButtons()
		{
			DangoBrawlBackpackOptionProxy optionProxy = this.OptionProxy;
			if (optionProxy == null)
			{
				return;
			}
			optionProxy.RefreshOptionButtons();
		}

		// Token: 0x06042410 RID: 271376 RVA: 0x01013F27 File Offset: 0x01012127
		private void AcceptFromOperated(EBagOpKind kind, int uid)
		{
			if (kind == EBagOpKind.BagToBench)
			{
				this.Migrate(uid, this.BagZone, this.BenchZone);
				return;
			}
			if (kind != EBagOpKind.BenchToBag)
			{
				return;
			}
			this.Migrate(uid, this.BenchZone, this.BagZone);
		}

		// Token: 0x06042411 RID: 271377 RVA: 0x01013F5C File Offset: 0x0101215C
		private void AcceptFromProxy(int uid, bool toBench)
		{
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			ProxyVisual proxyVisual = ((viewRegistry != null) ? viewRegistry.ConsumePendingProxy(uid) : null) as ProxyVisual;
			if (proxyVisual == null)
			{
				return;
			}
			IDangoBrawlItemZone dangoBrawlItemZone = toBench ? this.BenchZone : this.BagZone;
			DangoBrawlItemBase dangoBrawlItemBase = this.ResolveItemData(uid, dangoBrawlItemZone);
			if (dangoBrawlItemBase == null)
			{
				proxyVisual.Destroy();
				return;
			}
			DangoBrawlViewItemBase panel = proxyVisual.DetachInnerPanel();
			if (dangoBrawlItemZone != null)
			{
				dangoBrawlItemZone.AcceptPanel(panel, dangoBrawlItemBase, true);
			}
		}

		// Token: 0x06042412 RID: 271378 RVA: 0x01013FC0 File Offset: 0x010121C0
		private void Migrate(int uid, IDangoBrawlItemZone from, IDangoBrawlItemZone to)
		{
			DangoBrawlViewItemBase dangoBrawlViewItemBase = (from != null) ? from.DetachPanel(uid) : null;
			DangoBrawlItemBase dangoBrawlItemBase = this.ResolveItemData(uid, to);
			if (dangoBrawlViewItemBase != null && dangoBrawlItemBase != null)
			{
				if (to != null)
				{
					to.AcceptPanel(dangoBrawlViewItemBase, dangoBrawlItemBase, true);
					return;
				}
			}
			else if ((to == null || !to.TryRefreshPanel(uid)) && to != null)
			{
				to.FallbackAddItemPanel(uid, true);
			}
		}

		// Token: 0x06042413 RID: 271379 RVA: 0x01014014 File Offset: 0x01012214
		private DangoBrawlItemBase ResolveItemData(int uid, IDangoBrawlItemZone targetZone)
		{
			if (targetZone == this.BagZone)
			{
				DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
				if (bagpackData == null)
				{
					return null;
				}
				return bagpackData.GetItem(uid);
			}
			else
			{
				if (targetZone != this.BenchZone)
				{
					return null;
				}
				DangoBrawlBenchData benchData = this.ActData.BenchData;
				if (benchData == null)
				{
					return null;
				}
				return benchData.GetItem(uid);
			}
		}

		// Token: 0x06042414 RID: 271380 RVA: 0x01014064 File Offset: 0x01012264
		private void OnSelectionChanged()
		{
			DangoBrawlTouchController touch = this.Touch;
			DangoBrawlSelection dangoBrawlSelection = (touch != null) ? touch.GetContext().GetSelection() : null;
			if (dangoBrawlSelection != null && dangoBrawlSelection.Id > 0)
			{
				this.SelectedTipsSource = dangoBrawlSelection.Source;
				this.SelectedTipsUid = dangoBrawlSelection.Id;
				this.SetTipsReason(DangoBrawlBackpackView.ETipsReason.Selected, true);
				return;
			}
			this.SelectedTipsUid = -1;
			this.SetTipsReason(DangoBrawlBackpackView.ETipsReason.Selected, false);
		}

		// Token: 0x06042415 RID: 271381 RVA: 0x010140C5 File Offset: 0x010122C5
		private void OnItemHoveredChange(int uid, EDragSourceKind source)
		{
			if (this.IsInteracting)
			{
				this.ClearTipsReasonHover();
				return;
			}
			if (uid > 0)
			{
				this.CancelHoverTipsHideTimer();
				this.HoverTipsSource = source;
				this.HoverTipsUid = uid;
				this.SetTipsReason(DangoBrawlBackpackView.ETipsReason.Hover, true);
				return;
			}
			this.ScheduleClearTipsReasonHover();
		}

		// Token: 0x06042416 RID: 271382 RVA: 0x01014100 File Offset: 0x01012300
		private void SetTipsReason(DangoBrawlBackpackView.ETipsReason reason, bool on)
		{
			this.TipsReasons = (on ? (this.TipsReasons | reason) : (this.TipsReasons & ~reason));
			if ((this.TipsReasons & DangoBrawlBackpackView.ETipsReason.Selected) != DangoBrawlBackpackView.ETipsReason.None)
			{
				this.ShowTipsFor(this.SelectedTipsSource, this.SelectedTipsUid, EDangoBrawlTipsOperationMode.Selected);
				return;
			}
			if ((this.TipsReasons & DangoBrawlBackpackView.ETipsReason.Hover) != DangoBrawlBackpackView.ETipsReason.None)
			{
				this.ShowTipsFor(this.HoverTipsSource, this.HoverTipsUid, EDangoBrawlTipsOperationMode.Hover);
				return;
			}
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.SetTipsVisible(false);
		}

		// Token: 0x06042417 RID: 271383 RVA: 0x01014178 File Offset: 0x01012378
		private void ShowTipsFor(EDragSourceKind source, int uid, EDangoBrawlTipsOperationMode operationMode)
		{
			if (uid <= 0)
			{
				DangoBrawlItemTipsBase itemTips = this.ItemTips;
				if (itemTips == null)
				{
					return;
				}
				itemTips.SetTipsVisible(false);
				return;
			}
			else
			{
				switch (source)
				{
				case EDragSourceKind.Shop:
				{
					DangoBrawlPnlShop shopPanel = this.ShopPanel;
					if (shopPanel == null)
					{
						return;
					}
					shopPanel.RefreshItemTips(uid, operationMode);
					return;
				}
				case EDragSourceKind.Bag:
				{
					DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
					if (backpackPanel == null)
					{
						return;
					}
					backpackPanel.RefreshItemTips(uid, operationMode);
					return;
				}
				case EDragSourceKind.Bench:
				{
					DangoBrawlPnlBench benchPanel = this.BenchPanel;
					if (benchPanel == null)
					{
						return;
					}
					benchPanel.RefreshItemTips(uid, operationMode);
					return;
				}
				default:
				{
					DangoBrawlItemTipsBase itemTips2 = this.ItemTips;
					if (itemTips2 == null)
					{
						return;
					}
					itemTips2.SetTipsVisible(false);
					return;
				}
				}
			}
		}

		// Token: 0x06042418 RID: 271384 RVA: 0x010141F9 File Offset: 0x010123F9
		private void TryPlayEventFly()
		{
			if (!this.EventUpdateArrived || !this.ThreeChooseClosed)
			{
				return;
			}
			this.EventUpdateArrived = false;
			this.ThreeChooseClosed = false;
			this.RefreshThenPlayEventFly().Forget();
		}

		// Token: 0x06042419 RID: 271385 RVA: 0x01014228 File Offset: 0x01012428
		private UniTask RefreshThenPlayEventFly()
		{
			DangoBrawlBackpackView.<RefreshThenPlayEventFly>d__121 <RefreshThenPlayEventFly>d__;
			<RefreshThenPlayEventFly>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshThenPlayEventFly>d__.<>4__this = this;
			<RefreshThenPlayEventFly>d__.<>1__state = -1;
			<RefreshThenPlayEventFly>d__.<>t__builder.Start<DangoBrawlBackpackView.<RefreshThenPlayEventFly>d__121>(ref <RefreshThenPlayEventFly>d__);
			return <RefreshThenPlayEventFly>d__.<>t__builder.Task;
		}

		// Token: 0x0604241A RID: 271386 RVA: 0x0101426C File Offset: 0x0101246C
		private UniTask RefreshEventInfoPanel()
		{
			DangoBrawlBackpackView.<RefreshEventInfoPanel>d__122 <RefreshEventInfoPanel>d__;
			<RefreshEventInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEventInfoPanel>d__.<>4__this = this;
			<RefreshEventInfoPanel>d__.<>1__state = -1;
			<RefreshEventInfoPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<RefreshEventInfoPanel>d__122>(ref <RefreshEventInfoPanel>d__);
			return <RefreshEventInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0604241B RID: 271387 RVA: 0x010142B0 File Offset: 0x010124B0
		private UniTask PlayEventChooseSeq(int selectedIndex)
		{
			DangoBrawlBackpackView.<PlayEventChooseSeq>d__123 <PlayEventChooseSeq>d__;
			<PlayEventChooseSeq>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEventChooseSeq>d__.<>4__this = this;
			<PlayEventChooseSeq>d__.selectedIndex = selectedIndex;
			<PlayEventChooseSeq>d__.<>1__state = -1;
			<PlayEventChooseSeq>d__.<>t__builder.Start<DangoBrawlBackpackView.<PlayEventChooseSeq>d__123>(ref <PlayEventChooseSeq>d__);
			return <PlayEventChooseSeq>d__.<>t__builder.Task;
		}

		// Token: 0x0604241C RID: 271388 RVA: 0x010142FB File Offset: 0x010124FB
		[NullableContext(1)]
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x0604241D RID: 271389 RVA: 0x010142FD File Offset: 0x010124FD
		[NullableContext(1)]
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
			if (sequenceStartEvent == "HpStart")
			{
				this.UpdateHpView(this.ActData.MyFighterMaxHp, true);
			}
		}

		// Token: 0x0604241E RID: 271390 RVA: 0x0101431E File Offset: 0x0101251E
		private void OnHpTweenUpdate(float value)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "DangoBrawlBattleUIText_030", new <>z__ReadOnlySingleElementList<object>((int)value));
		}

		// Token: 0x0604241F RID: 271391 RVA: 0x01014344 File Offset: 0x01012544
		[NullableContext(1)]
		private void OnItemTipsCombineInfoClick(DangoBrawlItemTipsData data)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = data.ItemId,
				AllowCombine = true,
				FocusUid = data.ItemUid.GetValueOrDefault(),
				UseActData = true,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true
			}, null);
		}

		// Token: 0x06042420 RID: 271392 RVA: 0x010143A0 File Offset: 0x010125A0
		private void OnFighterAttrChanged()
		{
			if (this.ActData.MyFighterMaxHp > this.DisplayedHp)
			{
				this.UpdateHpDeltaView(this.ActData.MyFighterMaxHp - this.DisplayedHp);
			}
			else
			{
				this.UpdateHpView(this.ActData.MyFighterMaxHp, false);
			}
			this.UpdateOverweightView();
		}

		// Token: 0x06042421 RID: 271393 RVA: 0x010143F2 File Offset: 0x010125F2
		private void OnCostChanged()
		{
			this.UpdateOverweightView();
		}

		// Token: 0x06042422 RID: 271394 RVA: 0x010143FA File Offset: 0x010125FA
		private void OnRoundStartEffectsReady()
		{
			if (this.ActData.FightersServerData.GetCostDelta() > 0)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlaySequencePurely("WeightUp", false, false);
			}
		}

		// Token: 0x06042423 RID: 271395 RVA: 0x01014426 File Offset: 0x01012626
		private void OnDangoBrawlChooseUiStateChanged(bool show)
		{
			UUIButtonComponent btnChooseRecover = this.BtnChooseRecover;
			if (btnChooseRecover == null)
			{
				return;
			}
			UUIItem rootComponent = btnChooseRecover.GetRootComponent();
			if (rootComponent == null)
			{
				return;
			}
			rootComponent.SetUIActive(!show);
		}

		// Token: 0x06042424 RID: 271396 RVA: 0x01014446 File Offset: 0x01012646
		private void OnCloseBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlPauseView, EDangoBrawlPauseViewFrom.BackpackView, null);
		}

		// Token: 0x06042425 RID: 271397 RVA: 0x0101445E File Offset: 0x0101265E
		private void OnHelpBtnCallBack()
		{
			TutorialController.Instance.OpenExclusiveTutorial(EExclusiveTutorialType.DangoBrawl);
		}

		// Token: 0x06042426 RID: 271398 RVA: 0x01014470 File Offset: 0x01012670
		private void OnClickLevelDetail()
		{
			DangoBrawlInstBaseNotify instBase = this.ActData.InstBase;
			int levelId = (instBase != null) ? instBase.ChallengeId : 0;
			DangoBrawlInstBaseNotify instBase2 = this.ActData.InstBase;
			int retryCount = (instBase2 != null) ? instBase2.LoseCount : 0;
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlLevelDetailView, new DangoBrawlLevelDetailViewOpenData
			{
				LevelId = levelId,
				RetryCount = retryCount
			}, null);
		}

		// Token: 0x06042427 RID: 271399 RVA: 0x010144D0 File Offset: 0x010126D0
		private void OnClickCollection()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookView, null, null);
		}

		// Token: 0x06042428 RID: 271400 RVA: 0x010144E3 File Offset: 0x010126E3
		private void OnMaskBtnClick()
		{
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.TryCancelInteraction();
		}

		// Token: 0x06042429 RID: 271401 RVA: 0x010144F5 File Offset: 0x010126F5
		private void OnChooseRevoverBtnClick()
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlThreeChooseRecover);
		}

		// Token: 0x0604242A RID: 271402 RVA: 0x01014508 File Offset: 0x01012708
		private void OnToggleLayer(EToggleState state)
		{
			if (this.Layer == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.LSH, "OnToggleLayer: Layer 为空，忽略切换", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (state == EToggleState.ETT_Checked)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips009", Array.Empty<object>());
				this.TryEnterLayerMode(this.Layer);
				return;
			}
			this.TryExitLayerMode(this.Layer).Forget();
		}

		// Token: 0x0604242B RID: 271403 RVA: 0x01014573 File Offset: 0x01012773
		private void OnShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			this.AcceptFromProxy(uid, toBench);
		}

		// Token: 0x0604242C RID: 271404 RVA: 0x0101457E File Offset: 0x0101277E
		[NullableContext(1)]
		private void OnShopComposed(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			if (ActivityDangoBrawlController.Instance.ConsumeComposeFirstUnlock)
			{
				DangoBrawlAchievementTips achievementTipsPanel = this.AchievementTipsPanel;
				if (achievementTipsPanel == null)
				{
					return;
				}
				achievementTipsPanel.ShowTips(configId);
			}
		}

		// Token: 0x0604242D RID: 271405 RVA: 0x0101459D File Offset: 0x0101279D
		private void OnActiveEventsUpdated()
		{
			this.EventUpdateArrived = true;
			this.TryPlayEventFly();
		}

		// Token: 0x0604242E RID: 271406 RVA: 0x010145AC File Offset: 0x010127AC
		private void OnThreeChooseClosed()
		{
			this.ThreeChooseClosed = true;
			this.TryPlayEventFly();
			UUIButtonComponent btnChooseRecover = this.BtnChooseRecover;
			if (btnChooseRecover == null)
			{
				return;
			}
			UUIItem rootComponent = btnChooseRecover.GetRootComponent();
			if (rootComponent == null)
			{
				return;
			}
			rootComponent.SetUIActive(false);
		}

		// Token: 0x0604242F RID: 271407 RVA: 0x010145D6 File Offset: 0x010127D6
		private void OnDangoBrawlBagOperated(EBagOpKind kind, int uid)
		{
			this.AcceptFromOperated(kind, uid);
		}

		// Token: 0x06042430 RID: 271408 RVA: 0x010145E0 File Offset: 0x010127E0
		private void OnLayerModeChanged(bool isLayerMode)
		{
			this.UpdateInteractiveVisual();
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely(isLayerMode ? "BagLayerIn" : "BagLayerOut", false, false);
		}

		// Token: 0x06042431 RID: 271409 RVA: 0x01014609 File Offset: 0x01012809
		private void OnDragWillBegin(EDragSourceKind source, int uid)
		{
			this.ClearTipsReasonHover();
		}

		// Token: 0x06042432 RID: 271410 RVA: 0x01014614 File Offset: 0x01012814
		private void OnDragBegin(EDragSourceKind source, int configId)
		{
			this.SetDragVisualState(true);
			this.SetSellPanelActive(!this.IsLayerMode && (source == EDragSourceKind.Bag || source == EDragSourceKind.Bench), configId);
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null && touch.GetInputPlatform() == EInputPlatform.Mobile)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlaySequencePurely("TipsIn", false, false);
			}
		}

		// Token: 0x06042433 RID: 271411 RVA: 0x01014673 File Offset: 0x01012873
		private void OnDragEnd()
		{
			this.SetSellPanelActive(false, 0);
			this.SetDragVisualState(false);
		}

		// Token: 0x06042434 RID: 271412 RVA: 0x01014684 File Offset: 0x01012884
		private void OnDragEndAnyWay()
		{
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null && touch.GetInputPlatform() == EInputPlatform.Mobile)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlaySequencePurely("TipsOut", false, false);
			}
		}

		// Token: 0x06042435 RID: 271413 RVA: 0x010146B4 File Offset: 0x010128B4
		private void OnInteractionStateChanged(EInteractionState state)
		{
			if (state != EInteractionState.Idle)
			{
				if (state - EInteractionState.Holding > 1)
				{
					return;
				}
				this.SetDragVisualState(true);
				DangoBrawlTouchController touch = this.Touch;
				InteractionPayload interactionPayload = (touch != null) ? touch.GetInteractionFsm().GetPayLoad() : null;
				EDragSourceKind? edragSourceKind = (interactionPayload != null) ? new EDragSourceKind?(interactionPayload.Visual.Source) : null;
				bool active = !this.IsLayerMode && (edragSourceKind.GetValueOrDefault() == EDragSourceKind.Bag || edragSourceKind.GetValueOrDefault() == EDragSourceKind.Bench);
				this.SetSellPanelActive(active, (interactionPayload != null) ? interactionPayload.Visual.ConfigId : 0);
			}
			else
			{
				this.SetDragVisualState(false);
				DangoBrawlTouchController touch2 = this.Touch;
				if (touch2 == null || !touch2.IsDragging)
				{
					this.SetSellPanelActive(false, 0);
					return;
				}
			}
		}

		// Token: 0x06042436 RID: 271414 RVA: 0x01014770 File Offset: 0x01012970
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			int num2;
			int num3;
			if (configParams.Length == 2 && configParams[0] == "StoreItem" && int.TryParse(configParams[1], out num))
			{
				DangoBrawlPnlShop shopPanel = this.ShopPanel;
				UUIItem uuiitem = (shopPanel != null) ? shopPanel.GetGoodsSlotRootItem(num - 1) : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			else if (configParams.Length == 2 && configParams[0] == "CombineItem" && int.TryParse(configParams[1], out num2))
			{
				DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
				UUIItem uuiitem2 = (backpackPanel != null) ? backpackPanel.GetCombineItemRootItem(num2 - 1) : null;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
			else if (configParams.Length == 2 && configParams[0] == "Bag" && int.TryParse(configParams[1], out num3))
			{
				DangoBrawlPnlBackpack backpackPanel2 = this.BackpackPanel;
				UUIItem uuiitem3 = (backpackPanel2 != null) ? backpackPanel2.GetBagRootItem(num3 - 1) : null;
				if (uuiitem3 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem3,
					uuiitem3
				};
			}
			else
			{
				if (configParams.Length != 1 || !(configParams[0] == "FirstWeaponWeight"))
				{
					return null;
				}
				DangoBrawlPnlBackpack backpackPanel3 = this.BackpackPanel;
				UUIItem uuiitem4 = (backpackPanel3 != null) ? backpackPanel3.GetFirstWeaponWeightRootItem() : null;
				if (uuiitem4 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem4,
					uuiitem4
				};
			}
		}

		// Token: 0x0402290D RID: 141581
		[Nullable(1)]
		private ActivityDangoBrawlData ActData;

		// Token: 0x0402290E RID: 141582
		private DangoBrawlBackpackFight FightPanel;

		// Token: 0x0402290F RID: 141583
		private DangoBrawlPnlShop ShopPanel;

		// Token: 0x04022910 RID: 141584
		private DangoBrawlPnlBench BenchPanel;

		// Token: 0x04022911 RID: 141585
		private DangoBrawlPnlBackpack BackpackPanel;

		// Token: 0x04022912 RID: 141586
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x04022913 RID: 141587
		private DangoBrawlEventInfoPanel EventInfoPanel;

		// Token: 0x04022914 RID: 141588
		private DangoBrawlBackpackOccupationBtnItem BtnRoleOccupation;

		// Token: 0x04022915 RID: 141589
		private DangoBrawlBackpackView.ETipsReason TipsReasons;

		// Token: 0x04022916 RID: 141590
		private EDragSourceKind SelectedTipsSource;

		// Token: 0x04022917 RID: 141591
		private EDragSourceKind HoverTipsSource;

		// Token: 0x04022918 RID: 141592
		private int SelectedTipsUid;

		// Token: 0x04022919 RID: 141593
		private int HoverTipsUid;

		// Token: 0x0402291A RID: 141594
		private TimerHandle HoverTipsHideTimer;

		// Token: 0x0402291B RID: 141595
		private DangoBrawlAchievementTips AchievementTipsPanel;

		// Token: 0x0402291C RID: 141596
		private int DisplayedHp;

		// Token: 0x0402291D RID: 141597
		private bool IsOverweight;

		// Token: 0x0402291E RID: 141598
		private bool IsSellPanelActive;

		// Token: 0x0402291F RID: 141599
		private DangoBrawlBackpackTalkController TalkController;

		// Token: 0x04022920 RID: 141600
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04022921 RID: 141601
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022922 RID: 141602
		private DangoBrawlBackpackOptionProxy OptionProxy;

		// Token: 0x04022923 RID: 141603
		private DangoBrawlBackpackHotKeyProxy HotKeyProxy;

		// Token: 0x04022924 RID: 141604
		private LguiFloatTween HpTween;

		// Token: 0x04022925 RID: 141605
		private LguiFloatTween EventFlyTween;

		// Token: 0x04022926 RID: 141606
		private bool EventUpdateArrived;

		// Token: 0x04022927 RID: 141607
		private bool ThreeChooseClosed;

		// Token: 0x04022928 RID: 141608
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x04022929 RID: 141609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonPromise;

		// Token: 0x0200C900 RID: 51456
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CAE6 RID: 248550
			PnlShop,
			// Token: 0x0403CAE7 RID: 248551
			PnlBench,
			// Token: 0x0403CAE8 RID: 248552
			PnlBackpack,
			// Token: 0x0403CAE9 RID: 248553
			ItemCaption,
			// Token: 0x0403CAEA RID: 248554
			PnlTop,
			// Token: 0x0403CAEB RID: 248555
			BtnLevelDetail,
			// Token: 0x0403CAEC RID: 248556
			BtnCollection,
			// Token: 0x0403CAED RID: 248557
			TogLayer,
			// Token: 0x0403CAEE RID: 248558
			SpineActor,
			// Token: 0x0403CAEF RID: 248559
			PnlChat,
			// Token: 0x0403CAF0 RID: 248560
			TxtChat,
			// Token: 0x0403CAF1 RID: 248561
			TxtHp,
			// Token: 0x0403CAF2 RID: 248562
			PnlHpAdd,
			// Token: 0x0403CAF3 RID: 248563
			TxtHpAdd,
			// Token: 0x0403CAF4 RID: 248564
			ItemFight,
			// Token: 0x0403CAF5 RID: 248565
			PnlMobileDrag,
			// Token: 0x0403CAF6 RID: 248566
			BtnMask,
			// Token: 0x0403CAF7 RID: 248567
			TopPos,
			// Token: 0x0403CAF8 RID: 248568
			BottomPos,
			// Token: 0x0403CAF9 RID: 248569
			ItemTips,
			// Token: 0x0403CAFA RID: 248570
			PnlDragRoot,
			// Token: 0x0403CAFB RID: 248571
			AchievementTips,
			// Token: 0x0403CAFC RID: 248572
			EventPanel,
			// Token: 0x0403CAFD RID: 248573
			ItemBag,
			// Token: 0x0403CAFE RID: 248574
			ItemBagItem,
			// Token: 0x0403CAFF RID: 248575
			ContentOption,
			// Token: 0x0403CB00 RID: 248576
			BtnOptionRevert,
			// Token: 0x0403CB01 RID: 248577
			BtnOptionSell,
			// Token: 0x0403CB02 RID: 248578
			BtnOptionRotate,
			// Token: 0x0403CB03 RID: 248579
			BtnOptionReplace,
			// Token: 0x0403CB04 RID: 248580
			TxtOptionSellNum,
			// Token: 0x0403CB05 RID: 248581
			PnlPcHotKey,
			// Token: 0x0403CB06 RID: 248582
			ItemEvent01,
			// Token: 0x0403CB07 RID: 248583
			ItemEvent02,
			// Token: 0x0403CB08 RID: 248584
			ItemEvent03,
			// Token: 0x0403CB09 RID: 248585
			BtnRoleOccupation,
			// Token: 0x0403CB0A RID: 248586
			BtnChooseRecover
		}

		// Token: 0x0200C901 RID: 51457
		[NullableContext(0)]
		[Flags]
		private enum ETipsReason
		{
			// Token: 0x0403CB0C RID: 248588
			None = 0,
			// Token: 0x0403CB0D RID: 248589
			Selected = 1,
			// Token: 0x0403CB0E RID: 248590
			Hover = 2
		}
	}
}
