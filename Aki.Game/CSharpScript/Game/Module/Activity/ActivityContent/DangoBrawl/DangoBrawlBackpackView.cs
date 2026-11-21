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
	// Token: 0x02005736 RID: 22326
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBackpackView : UiTickViewBase
	{
		// Token: 0x17006A3A RID: 27194
		// (get) Token: 0x06036F20 RID: 225056 RVA: 0x00F53BFC File Offset: 0x00F51DFC
		private bool IsLayerMode
		{
			get
			{
				DangoBrawlDataController dataController = DangoBrawlModel.Instance.GetDataController();
				return dataController != null && dataController.GetViewLayerMode();
			}
		}

		// Token: 0x17006A3B RID: 27195
		// (get) Token: 0x06036F21 RID: 225057 RVA: 0x00F53C13 File Offset: 0x00F51E13
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

		// Token: 0x17006A3C RID: 27196
		// (get) Token: 0x06036F22 RID: 225058 RVA: 0x00F53C3C File Offset: 0x00F51E3C
		private IDangoBrawlItemZone BagZone
		{
			get
			{
				return this.BackpackPanel;
			}
		}

		// Token: 0x17006A3D RID: 27197
		// (get) Token: 0x06036F23 RID: 225059 RVA: 0x00F53C44 File Offset: 0x00F51E44
		private IDangoBrawlItemZone BenchZone
		{
			get
			{
				return this.BenchPanel;
			}
		}

		// Token: 0x17006A3E RID: 27198
		// (get) Token: 0x06036F24 RID: 225060 RVA: 0x00F53C4C File Offset: 0x00F51E4C
		private UUIItem PnlTop
		{
			get
			{
				return base.GetItem(4);
			}
		}

		// Token: 0x17006A3F RID: 27199
		// (get) Token: 0x06036F25 RID: 225061 RVA: 0x00F53C55 File Offset: 0x00F51E55
		private UUIItem PnlDragRoot
		{
			get
			{
				return base.GetItem(20);
			}
		}

		// Token: 0x17006A40 RID: 27200
		// (get) Token: 0x06036F26 RID: 225062 RVA: 0x00F53C5F File Offset: 0x00F51E5F
		private UUIExtendToggle TogLayer
		{
			get
			{
				return base.GetExtendToggle(7);
			}
		}

		// Token: 0x17006A41 RID: 27201
		// (get) Token: 0x06036F27 RID: 225063 RVA: 0x00F53C68 File Offset: 0x00F51E68
		private UUIButtonComponent BtnChooseRecover
		{
			get
			{
				return base.GetButton(36);
			}
		}

		// Token: 0x17006A42 RID: 27202
		// (get) Token: 0x06036F28 RID: 225064 RVA: 0x00F53C72 File Offset: 0x00F51E72
		private DangoBrawlItemViewRegistry ViewRegistry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x17006A43 RID: 27203
		// (get) Token: 0x06036F29 RID: 225065 RVA: 0x00F53C7E File Offset: 0x00F51E7E
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17006A44 RID: 27204
		// (get) Token: 0x06036F2A RID: 225066 RVA: 0x00F53C8A File Offset: 0x00F51E8A
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

		// Token: 0x06036F2B RID: 225067 RVA: 0x00F53CA1 File Offset: 0x00F51EA1
		[NullableContext(1)]
		public DangoBrawlBackpackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036F2C RID: 225068 RVA: 0x00F53CAC File Offset: 0x00F51EAC
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

		// Token: 0x06036F2D RID: 225069 RVA: 0x00F54280 File Offset: 0x00F52480
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBackpackView.<OnBeforeStartAsync>d__55 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBackpackView.<OnBeforeStartAsync>d__55>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036F2E RID: 225070 RVA: 0x00F542C3 File Offset: 0x00F524C3
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

		// Token: 0x06036F2F RID: 225071 RVA: 0x00F542F4 File Offset: 0x00F524F4
		protected override void OnBeforeShow()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, true, true, 0);
		}

		// Token: 0x06036F30 RID: 225072 RVA: 0x00F54311 File Offset: 0x00F52511
		protected override void OnBeforeHide()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, false, true, 0);
		}

		// Token: 0x06036F31 RID: 225073 RVA: 0x00F54330 File Offset: 0x00F52530
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

		// Token: 0x06036F32 RID: 225074 RVA: 0x00F54380 File Offset: 0x00F52580
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

		// Token: 0x06036F33 RID: 225075 RVA: 0x00F5456C File Offset: 0x00F5276C
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

		// Token: 0x06036F34 RID: 225076 RVA: 0x00F54755 File Offset: 0x00F52955
		public UUIItem GetBenchHitItem()
		{
			DangoBrawlPnlBench benchPanel = this.BenchPanel;
			if (benchPanel == null)
			{
				return null;
			}
			return benchPanel.HitItem;
		}

		// Token: 0x06036F35 RID: 225077 RVA: 0x00F54768 File Offset: 0x00F52968
		public UUIItem GetBagHitItem()
		{
			DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return null;
			}
			return backpackPanel.HitItem;
		}

		// Token: 0x06036F36 RID: 225078 RVA: 0x00F5477B File Offset: 0x00F5297B
		public UUIItem GetShopHitItem()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return null;
			}
			return shopPanel.HitItem;
		}

		// Token: 0x06036F37 RID: 225079 RVA: 0x00F54790 File Offset: 0x00F52990
		private UniTask CreateFightPanel()
		{
			DangoBrawlBackpackView.<CreateFightPanel>d__65 <CreateFightPanel>d__;
			<CreateFightPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFightPanel>d__.<>4__this = this;
			<CreateFightPanel>d__.<>1__state = -1;
			<CreateFightPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateFightPanel>d__65>(ref <CreateFightPanel>d__);
			return <CreateFightPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036F38 RID: 225080 RVA: 0x00F547D4 File Offset: 0x00F529D4
		private UniTask CreateShopPanel()
		{
			DangoBrawlBackpackView.<CreateShopPanel>d__66 <CreateShopPanel>d__;
			<CreateShopPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateShopPanel>d__.<>4__this = this;
			<CreateShopPanel>d__.<>1__state = -1;
			<CreateShopPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateShopPanel>d__66>(ref <CreateShopPanel>d__);
			return <CreateShopPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036F39 RID: 225081 RVA: 0x00F54818 File Offset: 0x00F52A18
		private UniTask CreateBenchPanel()
		{
			DangoBrawlBackpackView.<CreateBenchPanel>d__67 <CreateBenchPanel>d__;
			<CreateBenchPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBenchPanel>d__.<>4__this = this;
			<CreateBenchPanel>d__.<>1__state = -1;
			<CreateBenchPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateBenchPanel>d__67>(ref <CreateBenchPanel>d__);
			return <CreateBenchPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036F3A RID: 225082 RVA: 0x00F5485C File Offset: 0x00F52A5C
		public UniTask CreateBackpackPanel()
		{
			DangoBrawlBackpackView.<CreateBackpackPanel>d__68 <CreateBackpackPanel>d__;
			<CreateBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBackpackPanel>d__.<>4__this = this;
			<CreateBackpackPanel>d__.<>1__state = -1;
			<CreateBackpackPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateBackpackPanel>d__68>(ref <CreateBackpackPanel>d__);
			return <CreateBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036F3B RID: 225083 RVA: 0x00F548A0 File Offset: 0x00F52AA0
		public UniTask CreateItemTips()
		{
			DangoBrawlBackpackView.<CreateItemTips>d__69 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateItemTips>d__69>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x06036F3C RID: 225084 RVA: 0x00F548E4 File Offset: 0x00F52AE4
		private UniTask CreateAchievementTips()
		{
			DangoBrawlBackpackView.<CreateAchievementTips>d__70 <CreateAchievementTips>d__;
			<CreateAchievementTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAchievementTips>d__.<>4__this = this;
			<CreateAchievementTips>d__.<>1__state = -1;
			<CreateAchievementTips>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateAchievementTips>d__70>(ref <CreateAchievementTips>d__);
			return <CreateAchievementTips>d__.<>t__builder.Task;
		}

		// Token: 0x06036F3D RID: 225085 RVA: 0x00F54928 File Offset: 0x00F52B28
		private UniTask CreateEventInfoPanel()
		{
			DangoBrawlBackpackView.<CreateEventInfoPanel>d__71 <CreateEventInfoPanel>d__;
			<CreateEventInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateEventInfoPanel>d__.<>4__this = this;
			<CreateEventInfoPanel>d__.<>1__state = -1;
			<CreateEventInfoPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateEventInfoPanel>d__71>(ref <CreateEventInfoPanel>d__);
			return <CreateEventInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036F3E RID: 225086 RVA: 0x00F5496C File Offset: 0x00F52B6C
		private UniTask CreateCaptionItem()
		{
			DangoBrawlBackpackView.<CreateCaptionItem>d__72 <CreateCaptionItem>d__;
			<CreateCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionItem>d__.<>4__this = this;
			<CreateCaptionItem>d__.<>1__state = -1;
			<CreateCaptionItem>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateCaptionItem>d__72>(ref <CreateCaptionItem>d__);
			return <CreateCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x06036F3F RID: 225087 RVA: 0x00F549B0 File Offset: 0x00F52BB0
		private UniTask CreateOccupationBtnItem()
		{
			DangoBrawlBackpackView.<CreateOccupationBtnItem>d__73 <CreateOccupationBtnItem>d__;
			<CreateOccupationBtnItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateOccupationBtnItem>d__.<>4__this = this;
			<CreateOccupationBtnItem>d__.<>1__state = -1;
			<CreateOccupationBtnItem>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateOccupationBtnItem>d__73>(ref <CreateOccupationBtnItem>d__);
			return <CreateOccupationBtnItem>d__.<>t__builder.Task;
		}

		// Token: 0x06036F40 RID: 225088 RVA: 0x00F549F3 File Offset: 0x00F52BF3
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

		// Token: 0x06036F41 RID: 225089 RVA: 0x00F54A2C File Offset: 0x00F52C2C
		public UniTask CreateRoleSpine()
		{
			DangoBrawlBackpackView.<CreateRoleSpine>d__75 <CreateRoleSpine>d__;
			<CreateRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRoleSpine>d__.<>4__this = this;
			<CreateRoleSpine>d__.<>1__state = -1;
			<CreateRoleSpine>d__.<>t__builder.Start<DangoBrawlBackpackView.<CreateRoleSpine>d__75>(ref <CreateRoleSpine>d__);
			return <CreateRoleSpine>d__.<>t__builder.Task;
		}

		// Token: 0x06036F42 RID: 225090 RVA: 0x00F54A6F File Offset: 0x00F52C6F
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

		// Token: 0x06036F43 RID: 225091 RVA: 0x00F54AA8 File Offset: 0x00F52CA8
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

		// Token: 0x06036F44 RID: 225092 RVA: 0x00F54B30 File Offset: 0x00F52D30
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

		// Token: 0x06036F45 RID: 225093 RVA: 0x00F54B88 File Offset: 0x00F52D88
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

		// Token: 0x06036F46 RID: 225094 RVA: 0x00F54BEB File Offset: 0x00F52DEB
		private void ClearTalkController()
		{
			DangoBrawlBackpackTalkController talkController = this.TalkController;
			if (talkController != null)
			{
				talkController.Destroy();
			}
			this.TalkController = null;
		}

		// Token: 0x06036F47 RID: 225095 RVA: 0x00F54C08 File Offset: 0x00F52E08
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

		// Token: 0x06036F48 RID: 225096 RVA: 0x00F54C59 File Offset: 0x00F52E59
		private void InitWeightView()
		{
			this.IsOverweight = this.CalcOverweight();
		}

		// Token: 0x06036F49 RID: 225097 RVA: 0x00F54C68 File Offset: 0x00F52E68
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

		// Token: 0x06036F4A RID: 225098 RVA: 0x00F54CC8 File Offset: 0x00F52EC8
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

		// Token: 0x06036F4B RID: 225099 RVA: 0x00F54D10 File Offset: 0x00F52F10
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

		// Token: 0x06036F4C RID: 225100 RVA: 0x00F54D88 File Offset: 0x00F52F88
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

		// Token: 0x06036F4D RID: 225101 RVA: 0x00F54DEC File Offset: 0x00F52FEC
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

		// Token: 0x06036F4E RID: 225102 RVA: 0x00F54E34 File Offset: 0x00F53034
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

		// Token: 0x06036F4F RID: 225103 RVA: 0x00F54EAC File Offset: 0x00F530AC
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

		// Token: 0x06036F50 RID: 225104 RVA: 0x00F54F40 File Offset: 0x00F53140
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

		// Token: 0x06036F51 RID: 225105 RVA: 0x00F55098 File Offset: 0x00F53298
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

		// Token: 0x06036F52 RID: 225106 RVA: 0x00F55110 File Offset: 0x00F53310
		private bool CalcOverweight()
		{
			DangoBrawlDataController dataController = DangoBrawlModel.Instance.GetDataController();
			int num = (dataController != null) ? dataController.GetDisplayCost() : 0;
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int num2 = (selfFighter != null) ? selfFighter.Cost : 0;
			return num > num2;
		}

		// Token: 0x06036F53 RID: 225107 RVA: 0x00F55154 File Offset: 0x00F53354
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

		// Token: 0x06036F54 RID: 225108 RVA: 0x00F551A5 File Offset: 0x00F533A5
		private void ClearTipsReasonHover()
		{
			this.CancelHoverTipsHideTimer();
			this.HoverTipsUid = -1;
			this.SetTipsReason(DangoBrawlBackpackView.ETipsReason.Hover, false);
		}

		// Token: 0x06036F55 RID: 225109 RVA: 0x00F551BC File Offset: 0x00F533BC
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

		// Token: 0x06036F56 RID: 225110 RVA: 0x00F551ED File Offset: 0x00F533ED
		private void CancelHoverTipsHideTimer()
		{
			TimerHandle hoverTipsHideTimer = this.HoverTipsHideTimer;
			if (hoverTipsHideTimer != null)
			{
				hoverTipsHideTimer.Remove();
			}
			this.HoverTipsHideTimer = null;
		}

		// Token: 0x06036F57 RID: 225111 RVA: 0x00F55208 File Offset: 0x00F53408
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

		// Token: 0x06036F58 RID: 225112 RVA: 0x00F55228 File Offset: 0x00F53428
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

		// Token: 0x06036F59 RID: 225113 RVA: 0x00F55273 File Offset: 0x00F53473
		public int BeginSellCoinHold()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return 0;
			}
			return shopPanel.BeginSellCoinHold();
		}

		// Token: 0x06036F5A RID: 225114 RVA: 0x00F55286 File Offset: 0x00F53486
		public int BeginGiveCoinHold()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return 0;
			}
			return shopPanel.BeginCoinHoldWithFlush();
		}

		// Token: 0x06036F5B RID: 225115 RVA: 0x00F55299 File Offset: 0x00F53499
		public void SetSellRaycastActive(bool active)
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return;
			}
			shopPanel.SetSellRaycastActive(active);
		}

		// Token: 0x06036F5C RID: 225116 RVA: 0x00F552AC File Offset: 0x00F534AC
		public void CancelSell(int token)
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return;
			}
			shopPanel.EndSellCoinHold(token, false);
		}

		// Token: 0x06036F5D RID: 225117 RVA: 0x00F552C0 File Offset: 0x00F534C0
		public void FlushCoinHold(int token)
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return;
			}
			shopPanel.EndSellCoinHold(token, true);
		}

		// Token: 0x06036F5E RID: 225118 RVA: 0x00F552D4 File Offset: 0x00F534D4
		public UUIItem GetShopGoldItem()
		{
			DangoBrawlPnlShop shopPanel = this.ShopPanel;
			if (shopPanel == null)
			{
				return null;
			}
			return shopPanel.GetGoldItem();
		}

		// Token: 0x06036F5F RID: 225119 RVA: 0x00F552E7 File Offset: 0x00F534E7
		public UUIItem GetFirstCombineItemRootItem()
		{
			DangoBrawlPnlBackpack backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return null;
			}
			return backpackPanel.GetFirstCombineItemRootItem();
		}

		// Token: 0x06036F60 RID: 225120 RVA: 0x00F552FA File Offset: 0x00F534FA
		public bool IsFightBtnInteractive()
		{
			DangoBrawlBackpackFight fightPanel = this.FightPanel;
			return fightPanel != null && fightPanel.IsFightBtnInteractive();
		}

		// Token: 0x06036F61 RID: 225121 RVA: 0x00F5530D File Offset: 0x00F5350D
		public void ClickFightBtn()
		{
			DangoBrawlBackpackFight fightPanel = this.FightPanel;
			if (fightPanel == null)
			{
				return;
			}
			fightPanel.ClickFight();
		}

		// Token: 0x06036F62 RID: 225122 RVA: 0x00F55320 File Offset: 0x00F53520
		private void CreateOptionProxy()
		{
			this.OptionProxy = new DangoBrawlBackpackOptionProxy(this.ActData, base.GetItem(25), base.GetButton(26), base.GetButton(27), base.GetButton(28), base.GetButton(29), base.GetText(30));
			this.OptionProxy.Start();
		}

		// Token: 0x06036F63 RID: 225123 RVA: 0x00F55379 File Offset: 0x00F53579
		private void ClearOptionProxy()
		{
			DangoBrawlBackpackOptionProxy optionProxy = this.OptionProxy;
			if (optionProxy != null)
			{
				optionProxy.Destroy();
			}
			this.OptionProxy = null;
		}

		// Token: 0x06036F64 RID: 225124 RVA: 0x00F55393 File Offset: 0x00F53593
		private void ClearHotKeyProxy()
		{
			DangoBrawlBackpackHotKeyProxy hotKeyProxy = this.HotKeyProxy;
			if (hotKeyProxy != null)
			{
				hotKeyProxy.Destroy();
			}
			this.HotKeyProxy = null;
		}

		// Token: 0x06036F65 RID: 225125 RVA: 0x00F553AD File Offset: 0x00F535AD
		private void RefreshOptionButtons()
		{
			DangoBrawlBackpackOptionProxy optionProxy = this.OptionProxy;
			if (optionProxy == null)
			{
				return;
			}
			optionProxy.RefreshOptionButtons();
		}

		// Token: 0x06036F66 RID: 225126 RVA: 0x00F553BF File Offset: 0x00F535BF
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

		// Token: 0x06036F67 RID: 225127 RVA: 0x00F553F4 File Offset: 0x00F535F4
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

		// Token: 0x06036F68 RID: 225128 RVA: 0x00F55458 File Offset: 0x00F53658
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

		// Token: 0x06036F69 RID: 225129 RVA: 0x00F554AC File Offset: 0x00F536AC
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

		// Token: 0x06036F6A RID: 225130 RVA: 0x00F554FC File Offset: 0x00F536FC
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

		// Token: 0x06036F6B RID: 225131 RVA: 0x00F5555D File Offset: 0x00F5375D
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

		// Token: 0x06036F6C RID: 225132 RVA: 0x00F55598 File Offset: 0x00F53798
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

		// Token: 0x06036F6D RID: 225133 RVA: 0x00F55610 File Offset: 0x00F53810
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

		// Token: 0x06036F6E RID: 225134 RVA: 0x00F55691 File Offset: 0x00F53891
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

		// Token: 0x06036F6F RID: 225135 RVA: 0x00F556C0 File Offset: 0x00F538C0
		private UniTask RefreshThenPlayEventFly()
		{
			DangoBrawlBackpackView.<RefreshThenPlayEventFly>d__121 <RefreshThenPlayEventFly>d__;
			<RefreshThenPlayEventFly>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshThenPlayEventFly>d__.<>4__this = this;
			<RefreshThenPlayEventFly>d__.<>1__state = -1;
			<RefreshThenPlayEventFly>d__.<>t__builder.Start<DangoBrawlBackpackView.<RefreshThenPlayEventFly>d__121>(ref <RefreshThenPlayEventFly>d__);
			return <RefreshThenPlayEventFly>d__.<>t__builder.Task;
		}

		// Token: 0x06036F70 RID: 225136 RVA: 0x00F55704 File Offset: 0x00F53904
		private UniTask RefreshEventInfoPanel()
		{
			DangoBrawlBackpackView.<RefreshEventInfoPanel>d__122 <RefreshEventInfoPanel>d__;
			<RefreshEventInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEventInfoPanel>d__.<>4__this = this;
			<RefreshEventInfoPanel>d__.<>1__state = -1;
			<RefreshEventInfoPanel>d__.<>t__builder.Start<DangoBrawlBackpackView.<RefreshEventInfoPanel>d__122>(ref <RefreshEventInfoPanel>d__);
			return <RefreshEventInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036F71 RID: 225137 RVA: 0x00F55748 File Offset: 0x00F53948
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

		// Token: 0x06036F72 RID: 225138 RVA: 0x00F55793 File Offset: 0x00F53993
		[NullableContext(1)]
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06036F73 RID: 225139 RVA: 0x00F55795 File Offset: 0x00F53995
		[NullableContext(1)]
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
			if (sequenceStartEvent == "HpStart")
			{
				this.UpdateHpView(this.ActData.MyFighterMaxHp, true);
			}
		}

		// Token: 0x06036F74 RID: 225140 RVA: 0x00F557B6 File Offset: 0x00F539B6
		private void OnHpTweenUpdate(float value)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "DangoBrawlBattleUIText_030", new <>z__ReadOnlySingleElementList<object>((int)value));
		}

		// Token: 0x06036F75 RID: 225141 RVA: 0x00F557DC File Offset: 0x00F539DC
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

		// Token: 0x06036F76 RID: 225142 RVA: 0x00F55838 File Offset: 0x00F53A38
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

		// Token: 0x06036F77 RID: 225143 RVA: 0x00F5588A File Offset: 0x00F53A8A
		private void OnCostChanged()
		{
			this.UpdateOverweightView();
		}

		// Token: 0x06036F78 RID: 225144 RVA: 0x00F55892 File Offset: 0x00F53A92
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

		// Token: 0x06036F79 RID: 225145 RVA: 0x00F558BE File Offset: 0x00F53ABE
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

		// Token: 0x06036F7A RID: 225146 RVA: 0x00F558DE File Offset: 0x00F53ADE
		private void OnCloseBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlPauseView, EDangoBrawlPauseViewFrom.BackpackView, null);
		}

		// Token: 0x06036F7B RID: 225147 RVA: 0x00F558F6 File Offset: 0x00F53AF6
		private void OnHelpBtnCallBack()
		{
			TutorialController.Instance.OpenExclusiveTutorial(EExclusiveTutorialType.DangoBrawl);
		}

		// Token: 0x06036F7C RID: 225148 RVA: 0x00F55908 File Offset: 0x00F53B08
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

		// Token: 0x06036F7D RID: 225149 RVA: 0x00F55968 File Offset: 0x00F53B68
		private void OnClickCollection()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookView, null, null);
		}

		// Token: 0x06036F7E RID: 225150 RVA: 0x00F5597B File Offset: 0x00F53B7B
		private void OnMaskBtnClick()
		{
			DangoBrawlTouchController touch = this.Touch;
			if (touch == null)
			{
				return;
			}
			touch.TryCancelInteraction();
		}

		// Token: 0x06036F7F RID: 225151 RVA: 0x00F5598D File Offset: 0x00F53B8D
		private void OnChooseRevoverBtnClick()
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlThreeChooseRecover);
		}

		// Token: 0x06036F80 RID: 225152 RVA: 0x00F559A0 File Offset: 0x00F53BA0
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

		// Token: 0x06036F81 RID: 225153 RVA: 0x00F55A0B File Offset: 0x00F53C0B
		private void OnShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			this.AcceptFromProxy(uid, toBench);
		}

		// Token: 0x06036F82 RID: 225154 RVA: 0x00F55A16 File Offset: 0x00F53C16
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

		// Token: 0x06036F83 RID: 225155 RVA: 0x00F55A35 File Offset: 0x00F53C35
		private void OnActiveEventsUpdated()
		{
			this.EventUpdateArrived = true;
			this.TryPlayEventFly();
		}

		// Token: 0x06036F84 RID: 225156 RVA: 0x00F55A44 File Offset: 0x00F53C44
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

		// Token: 0x06036F85 RID: 225157 RVA: 0x00F55A6E File Offset: 0x00F53C6E
		private void OnDangoBrawlBagOperated(EBagOpKind kind, int uid)
		{
			this.AcceptFromOperated(kind, uid);
		}

		// Token: 0x06036F86 RID: 225158 RVA: 0x00F55A78 File Offset: 0x00F53C78
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

		// Token: 0x06036F87 RID: 225159 RVA: 0x00F55AA1 File Offset: 0x00F53CA1
		private void OnDragWillBegin(EDragSourceKind source, int uid)
		{
			this.ClearTipsReasonHover();
		}

		// Token: 0x06036F88 RID: 225160 RVA: 0x00F55AAC File Offset: 0x00F53CAC
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

		// Token: 0x06036F89 RID: 225161 RVA: 0x00F55B0B File Offset: 0x00F53D0B
		private void OnDragEnd()
		{
			this.SetSellPanelActive(false, 0);
			this.SetDragVisualState(false);
		}

		// Token: 0x06036F8A RID: 225162 RVA: 0x00F55B1C File Offset: 0x00F53D1C
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

		// Token: 0x06036F8B RID: 225163 RVA: 0x00F55B4C File Offset: 0x00F53D4C
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

		// Token: 0x06036F8C RID: 225164 RVA: 0x00F55C08 File Offset: 0x00F53E08
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

		// Token: 0x0401D16A RID: 119146
		[Nullable(1)]
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D16B RID: 119147
		private DangoBrawlBackpackFight FightPanel;

		// Token: 0x0401D16C RID: 119148
		private DangoBrawlPnlShop ShopPanel;

		// Token: 0x0401D16D RID: 119149
		private DangoBrawlPnlBench BenchPanel;

		// Token: 0x0401D16E RID: 119150
		private DangoBrawlPnlBackpack BackpackPanel;

		// Token: 0x0401D16F RID: 119151
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401D170 RID: 119152
		private DangoBrawlEventInfoPanel EventInfoPanel;

		// Token: 0x0401D171 RID: 119153
		private DangoBrawlBackpackOccupationBtnItem BtnRoleOccupation;

		// Token: 0x0401D172 RID: 119154
		private DangoBrawlBackpackView.ETipsReason TipsReasons;

		// Token: 0x0401D173 RID: 119155
		private EDragSourceKind SelectedTipsSource;

		// Token: 0x0401D174 RID: 119156
		private EDragSourceKind HoverTipsSource;

		// Token: 0x0401D175 RID: 119157
		private int SelectedTipsUid;

		// Token: 0x0401D176 RID: 119158
		private int HoverTipsUid;

		// Token: 0x0401D177 RID: 119159
		private TimerHandle HoverTipsHideTimer;

		// Token: 0x0401D178 RID: 119160
		private DangoBrawlAchievementTips AchievementTipsPanel;

		// Token: 0x0401D179 RID: 119161
		private int DisplayedHp;

		// Token: 0x0401D17A RID: 119162
		private bool IsOverweight;

		// Token: 0x0401D17B RID: 119163
		private bool IsSellPanelActive;

		// Token: 0x0401D17C RID: 119164
		private DangoBrawlBackpackTalkController TalkController;

		// Token: 0x0401D17D RID: 119165
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401D17E RID: 119166
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D17F RID: 119167
		private DangoBrawlBackpackOptionProxy OptionProxy;

		// Token: 0x0401D180 RID: 119168
		private DangoBrawlBackpackHotKeyProxy HotKeyProxy;

		// Token: 0x0401D181 RID: 119169
		private LguiFloatTween HpTween;

		// Token: 0x0401D182 RID: 119170
		private LguiFloatTween EventFlyTween;

		// Token: 0x0401D183 RID: 119171
		private bool EventUpdateArrived;

		// Token: 0x0401D184 RID: 119172
		private bool ThreeChooseClosed;

		// Token: 0x0401D185 RID: 119173
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x0401D186 RID: 119174
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonPromise;

		// Token: 0x0200B2D0 RID: 45776
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040373DB RID: 226267
			PnlShop,
			// Token: 0x040373DC RID: 226268
			PnlBench,
			// Token: 0x040373DD RID: 226269
			PnlBackpack,
			// Token: 0x040373DE RID: 226270
			ItemCaption,
			// Token: 0x040373DF RID: 226271
			PnlTop,
			// Token: 0x040373E0 RID: 226272
			BtnLevelDetail,
			// Token: 0x040373E1 RID: 226273
			BtnCollection,
			// Token: 0x040373E2 RID: 226274
			TogLayer,
			// Token: 0x040373E3 RID: 226275
			SpineActor,
			// Token: 0x040373E4 RID: 226276
			PnlChat,
			// Token: 0x040373E5 RID: 226277
			TxtChat,
			// Token: 0x040373E6 RID: 226278
			TxtHp,
			// Token: 0x040373E7 RID: 226279
			PnlHpAdd,
			// Token: 0x040373E8 RID: 226280
			TxtHpAdd,
			// Token: 0x040373E9 RID: 226281
			ItemFight,
			// Token: 0x040373EA RID: 226282
			PnlMobileDrag,
			// Token: 0x040373EB RID: 226283
			BtnMask,
			// Token: 0x040373EC RID: 226284
			TopPos,
			// Token: 0x040373ED RID: 226285
			BottomPos,
			// Token: 0x040373EE RID: 226286
			ItemTips,
			// Token: 0x040373EF RID: 226287
			PnlDragRoot,
			// Token: 0x040373F0 RID: 226288
			AchievementTips,
			// Token: 0x040373F1 RID: 226289
			EventPanel,
			// Token: 0x040373F2 RID: 226290
			ItemBag,
			// Token: 0x040373F3 RID: 226291
			ItemBagItem,
			// Token: 0x040373F4 RID: 226292
			ContentOption,
			// Token: 0x040373F5 RID: 226293
			BtnOptionRevert,
			// Token: 0x040373F6 RID: 226294
			BtnOptionSell,
			// Token: 0x040373F7 RID: 226295
			BtnOptionRotate,
			// Token: 0x040373F8 RID: 226296
			BtnOptionReplace,
			// Token: 0x040373F9 RID: 226297
			TxtOptionSellNum,
			// Token: 0x040373FA RID: 226298
			PnlPcHotKey,
			// Token: 0x040373FB RID: 226299
			ItemEvent01,
			// Token: 0x040373FC RID: 226300
			ItemEvent02,
			// Token: 0x040373FD RID: 226301
			ItemEvent03,
			// Token: 0x040373FE RID: 226302
			BtnRoleOccupation,
			// Token: 0x040373FF RID: 226303
			BtnChooseRecover
		}

		// Token: 0x0200B2D1 RID: 45777
		[NullableContext(0)]
		[Flags]
		private enum ETipsReason
		{
			// Token: 0x04037401 RID: 226305
			None = 0,
			// Token: 0x04037402 RID: 226306
			Selected = 1,
			// Token: 0x04037403 RID: 226307
			Hover = 2
		}
	}
}
