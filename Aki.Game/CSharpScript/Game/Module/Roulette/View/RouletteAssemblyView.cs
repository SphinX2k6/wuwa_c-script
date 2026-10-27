using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Roulette.View.Components;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02004C9E RID: 19614
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteAssemblyView : UiTickViewBase
	{
		// Token: 0x17007D0A RID: 32010
		// (get) Token: 0x06032AE7 RID: 207591 RVA: 0x00BD29BB File Offset: 0x00BD0BBB
		private RouletteComponentAssembly RouletteComponent
		{
			get
			{
				return this.ViewProxy.GetRouletteComponent();
			}
		}

		// Token: 0x06032AE8 RID: 207592 RVA: 0x00BD29C8 File Offset: 0x00BD0BC8
		public RouletteAssemblyView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032AE9 RID: 207593 RVA: 0x00BD29E0 File Offset: 0x00BD0BE0
		protected unsafe override void OnRegisterComponent()
		{
			if (this.OpenParam == null)
			{
				Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YYZ, "[Roulette] 装配界面打开时未获取到参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.ViewProxy = (RouletteAssemblyViewProxy)this.OpenParam;
			}
			this.ViewProxy.RegisterView(this);
			int num = 17;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToggleLeftClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleRightClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action<EToggleState>(this.OnToggleConfigClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032AEA RID: 207594 RVA: 0x00BD2D0C File Offset: 0x00BD0F0C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
			EventSystem.Instance.Add<RouletteData>(EEventName.OnRouletteItemSelect, new Action<RouletteData>(this.OnRouletteButtonClicked));
			EventSystem.Instance.Add(EEventName.OnRouletteSaveDataChange, new Action(this.OnSaveDataChange));
			EventSystem.Instance.Add(EEventName.OnRouletteItemUnlock, new Action(this.OnButtonSwitch));
			EventSystem.Instance.Add(EEventName.RouletteNavigationComponentEmit, new Action(this.OnRouletteNavigationComponentEmit));
		}

		// Token: 0x06032AEB RID: 207595 RVA: 0x00BD2DA8 File Offset: 0x00BD0FA8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.OnRouletteItemSelect, new Action<RouletteData>(this.OnRouletteButtonClicked));
			EventSystem.Instance.Remove(EEventName.OnRouletteSaveDataChange, new Action(this.OnSaveDataChange));
			EventSystem.Instance.Remove(EEventName.OnRouletteItemUnlock, new Action(this.OnButtonSwitch));
			EventSystem.Instance.Remove(EEventName.RouletteNavigationComponentEmit, new Action(this.OnRouletteNavigationComponentEmit));
		}

		// Token: 0x06032AEC RID: 207596 RVA: 0x00BD2E44 File Offset: 0x00BD1044
		protected override UniTask OnBeforeStartAsync()
		{
			RouletteAssemblyView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RouletteAssemblyView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032AED RID: 207597 RVA: 0x00BD2E87 File Offset: 0x00BD1087
		protected override void OnStart()
		{
			this.InitRouletteInputManager();
			this.ViewProxy.Start();
		}

		// Token: 0x06032AEE RID: 207598 RVA: 0x00BD2E9C File Offset: 0x00BD109C
		protected override void OnBeforeDestroy()
		{
			this.SetExploreSkill();
			RouletteModel.Instance.SaveNewItemList();
			if (this.InputManager != null)
			{
				this.InputManager.Destroy();
				this.InputManager = null;
			}
			if (this.AssemblyGridScrollView != null)
			{
				this.AssemblyGridScrollView.ClearGridProxies();
				this.AssemblyGridScrollView = null;
			}
			this.CurrentSelectOnGridData = null;
			this.AssemblyTips.Destroy(null);
			this.ButtonSwitch.Destroy(null);
			this.CaptionItem.Destroy(null);
			this.SortEntrance.Destroy(null);
			this.ToggleLeft = null;
			this.ToggleRight = null;
			this.ViewProxy.Destroy();
		}

		// Token: 0x06032AEF RID: 207599 RVA: 0x00BD2F40 File Offset: 0x00BD1140
		protected override void OnBeforeShow()
		{
			if (this.IsFirstShow)
			{
				this.TabItem.SelectTab((int)this.ViewProxy.CurrentRouletteType);
				this.IsFirstShow = false;
			}
			else
			{
				this.RefreshScrollView(true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Phantom;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "刷新滑动列表2";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.ViewProxy.AssemblyGridDataMap", this.ViewProxy.AssemblyGridDataMap);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.ViewProxy.BeforeShow();
			RouletteAssemblyTips assemblyTips = this.AssemblyTips;
			if (assemblyTips != null)
			{
				assemblyTips.RefreshPhantomInteractEquipmentPanel();
			}
			ButtonItem buttonPhantomEdit = this.ButtonPhantomEdit;
			if (buttonPhantomEdit == null)
			{
				return;
			}
			buttonPhantomEdit.BindRedDot(ERedDotName.RedDotPhantomInteractEditEntry, 0);
		}

		// Token: 0x06032AF0 RID: 207600 RVA: 0x00BD2FDE File Offset: 0x00BD11DE
		protected override void OnAfterHide()
		{
			ButtonItem buttonPhantomEdit = this.ButtonPhantomEdit;
			if (buttonPhantomEdit == null)
			{
				return;
			}
			buttonPhantomEdit.UnBindGivenUid(0);
		}

		// Token: 0x06032AF1 RID: 207601 RVA: 0x00BD2FF4 File Offset: 0x00BD11F4
		protected override void OnTick(float delta)
		{
			ValueTuple<int?, int?> valueTuple = this.InputManager.Tick(delta);
			int? item = valueTuple.Item1;
			int? item2 = valueTuple.Item2;
			this.RouletteComponent.Refresh(item, item2);
		}

		// Token: 0x06032AF2 RID: 207602 RVA: 0x00BD3027 File Offset: 0x00BD1227
		private void OnRouletteTypeSwitch(int typeId)
		{
			this.ViewProxy.OnRouletteTypeSwitch((ERouletteType)typeId);
			this.RefreshTypeSwitch();
		}

		// Token: 0x06032AF3 RID: 207603 RVA: 0x00BD303C File Offset: 0x00BD123C
		private void RefreshTypeSwitch()
		{
			this.SetRouletteInputType();
			this.SetRoulettePlatformType();
			this.SetRouletteType();
			this.RouletteComponent.SetAllGridToggleSelfInteractive(true);
			this.RouletteComponent.AddAllGridToggleCanExecuteChangeEvent(new Func<RouletteData, EToggleState, bool>(this.OnCanRouletteToggleExecuteChange));
			this.AssemblyState = EAssemblyState.RouletteGridChoose;
			this.UpdateButtonEnable();
			this.SelectDefaultRouletteGrid();
		}

		// Token: 0x17007D0B RID: 32011
		// (get) Token: 0x06032AF4 RID: 207604 RVA: 0x00BD3091 File Offset: 0x00BD1291
		// (set) Token: 0x06032AF5 RID: 207605 RVA: 0x00BD309C File Offset: 0x00BD129C
		private EAssemblyState AssemblyState
		{
			get
			{
				return this.ViewAssemblyState;
			}
			set
			{
				this.ViewAssemblyState = value;
				if (value == EAssemblyState.RouletteGridChoose)
				{
					this.RouletteComponent.SetTipsActive(true);
					if (Info.Instance.IsInTouch())
					{
						this.RouletteComponent.RefreshTipsByText("Text_ExploreToolsChooseMobile_Text", false);
						this.RouletteComponent.SetNameVisible(false);
						this.RouletteComponent.SetRingVisible(false);
					}
					else if (Info.Instance.IsInGamepad())
					{
						this.RouletteComponent.RefreshTipsByText("Text_ExploreToolsChoosePC_Text", false);
						this.RouletteComponent.SetRingVisible(true);
					}
					else if (Info.Instance.IsInKeyBoard())
					{
						this.RouletteComponent.RefreshTipsByText("Text_ExploreToolsChoosePC_Text", false);
						this.RouletteComponent.SetRingVisible(false);
					}
					this.InputManager.ActivateInput(true);
					return;
				}
				if (value != EAssemblyState.ScrollViewChoose)
				{
					return;
				}
				this.RouletteComponent.SetTipsActive(false);
				this.RouletteComponent.SetRingVisible(false);
				if (Info.Instance.IsInTouch())
				{
					this.RouletteComponent.SetNameVisible(true);
				}
				this.InputManager.ActivateInput(false);
				this.RefreshTabToggle();
				this.RefreshScrollView(false);
				this.RefreshSwitchButton();
			}
		}

		// Token: 0x06032AF6 RID: 207606 RVA: 0x00BD31B0 File Offset: 0x00BD13B0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length != 1 || !int.TryParse(configParams[0], out num))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.JT;
				string message = "聚焦引导extraParam项配置有误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int num2 = int.Parse(configParams[0]);
			LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> assemblyGridScrollView = this.AssemblyGridScrollView;
			UUIItem uuiitem;
			if (assemblyGridScrollView == null)
			{
				uuiitem = null;
			}
			else
			{
				uuiitem = assemblyGridScrollView.GetGridAndScrollToByJudge(num2, (object itemIdObj, AssemblyGridData data) => (int)itemIdObj == data.Id, true);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 != null)
			{
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
			return null;
		}

		// Token: 0x06032AF7 RID: 207607 RVA: 0x00BD324D File Offset: 0x00BD144D
		private void SetRouletteType()
		{
			this.RouletteComponent.RefreshRouletteType();
		}

		// Token: 0x06032AF8 RID: 207608 RVA: 0x00BD325A File Offset: 0x00BD145A
		private void SetRoulettePlatformType()
		{
			this.RouletteComponent.RefreshRoulettePlatformType();
		}

		// Token: 0x06032AF9 RID: 207609 RVA: 0x00BD3268 File Offset: 0x00BD1468
		private void SetRouletteInputType()
		{
			this.RouletteComponent.RefreshRouletteInputType();
			bool flag = Info.Instance.IsInGamepad();
			base.GetItem(12).SetUIActive(flag);
			if (!flag)
			{
				return;
			}
			EToggleState state = (RouletteModel.Instance.GetRouletteSelectConfig() == 1) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(11).SetToggleState(state, false, false, false);
			UUIText text = base.GetText(13);
			LguiUtil.Instance.SetLocalTextNew(text, "Text_ExploreToolsClose_Text", Array.Empty<object>());
		}

		// Token: 0x06032AFA RID: 207610 RVA: 0x00BD32DF File Offset: 0x00BD14DF
		private void SwitchInputType()
		{
			this.SetRouletteInputType();
			this.InitRouletteInputManager();
			this.AssemblyState = EAssemblyState.RouletteGridChoose;
			this.SelectDefaultRouletteGrid();
		}

		// Token: 0x06032AFB RID: 207611 RVA: 0x00BD32FC File Offset: 0x00BD14FC
		private void OnButtonSwitch()
		{
			EAssemblyState assemblyState = (this.AssemblyState == EAssemblyState.RouletteGridChoose) ? EAssemblyState.ScrollViewChoose : EAssemblyState.RouletteGridChoose;
			this.AssemblyState = assemblyState;
		}

		// Token: 0x06032AFC RID: 207612 RVA: 0x00BD3320 File Offset: 0x00BD1520
		private void InputControllerMainTypeChange(EInputControllerMainType eInputControllerMainType, EInputControllerMainType inputControllerMainType)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "检测到输入设备变化,切换装配界面表现";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("新输入类型", Info.Instance.InputControllerType);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SwitchInputType();
		}

		// Token: 0x06032AFD RID: 207613 RVA: 0x00BD3368 File Offset: 0x00BD1568
		private void InitRouletteInputManager()
		{
			RouletteInputBase inputManager = this.InputManager;
			if (inputManager != null)
			{
				inputManager.Destroy();
			}
			this.InputManager = null;
			FVector lguispaceAbsolutePosition = base.GetItem(1).GetLGUISpaceAbsolutePosition();
			Vector2D beginPos = AngleCalculator.ConvertLguiPosToScreenPos((double)lguispaceAbsolutePosition.X, (double)lguispaceAbsolutePosition.Y);
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("Roulette_Assembly_Gamepad_DeadLimit");
			this.InputManager = RouletteInputManager.CreateInput(Info.Instance.InputControllerMainType, beginPos, new ERouletteViewType?(ERouletteViewType.Assembly), null, floatConfig);
			this.InputManager.BindEvent();
			this.InputManager.OnInit();
			this.InputManager.SetIsNeedEmpty(true);
		}

		// Token: 0x06032AFE RID: 207614 RVA: 0x00BD3404 File Offset: 0x00BD1604
		private void SelectDefaultRouletteGrid()
		{
			this.RouletteComponent.Reset();
			RouletteGridBase rouletteGridBase = null;
			if (this.ViewProxy.OpenParam.SelectGridId != null)
			{
				rouletteGridBase = this.RouletteComponent.GetGridByValidId(this.ViewProxy.OpenParam.SelectGridId.Value);
			}
			if (rouletteGridBase == null && this.ViewProxy.OpenParam.LocateEquippableSpecialItem.GetValueOrDefault())
			{
				rouletteGridBase = this.RouletteComponent.GetGridByType(ERouletteGridType.EquipItem);
				if (rouletteGridBase != null)
				{
					this.EquipItemType = InventoryDefine.EItemType.SpecialItem;
				}
			}
			if (rouletteGridBase == null)
			{
				int valueOrDefault = this.ViewProxy.OpenParam.SelectGridIndex.GetValueOrDefault();
				rouletteGridBase = this.RouletteComponent.GetGridByIndex(valueOrDefault);
			}
			rouletteGridBase.SetGridToggleState(true, false);
			rouletteGridBase.SetGridEquipped(true);
			this.OnRouletteButtonClicked(rouletteGridBase.Data);
			if (Info.Instance.IsInGamepad())
			{
				this.AssemblyState = EAssemblyState.RouletteGridChoose;
				return;
			}
			this.AssemblyState = EAssemblyState.ScrollViewChoose;
		}

		// Token: 0x06032AFF RID: 207615 RVA: 0x00BD34F0 File Offset: 0x00BD16F0
		private void OnRouletteButtonClicked(RouletteData data)
		{
			RouletteData currentSelectOnGridData = this.CurrentSelectOnGridData;
			int? num = (currentSelectOnGridData != null) ? new int?(currentSelectOnGridData.GridIndex) : null;
			this.CurrentSelectOnGridData = data;
			if (num != null)
			{
				int? num2 = num;
				int gridIndex = this.CurrentSelectOnGridData.GridIndex;
				if (!(num2.GetValueOrDefault() == gridIndex & num2 != null))
				{
					RouletteGridBase gridByIndex = this.RouletteComponent.GetGridByIndex(num.Value);
					if (gridByIndex != null)
					{
						gridByIndex.SetGridToggleState(false, true);
					}
				}
			}
			this.RouletteComponent.SetCurrentGridByData(data);
			this.AssemblyState = EAssemblyState.ScrollViewChoose;
		}

		// Token: 0x06032B00 RID: 207616 RVA: 0x00BD3584 File Offset: 0x00BD1784
		private bool OnCanRouletteToggleExecuteChange(RouletteData itemData, EToggleState state)
		{
			if (this.CurrentSelectOnGridData != null && state == EToggleState.ETT_Checked)
			{
				bool flag = this.CurrentSelectOnGridData.GridIndex == itemData.GridIndex;
				if (Info.Instance.IsInGamepad() && flag)
				{
					this.OnButtonSwitch();
				}
				return !flag;
			}
			return true;
		}

		// Token: 0x06032B01 RID: 207617 RVA: 0x00BD35CB File Offset: 0x00BD17CB
		private void InitScrollView()
		{
			this.AssemblyGridScrollView = new LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData>(base.GetLoopScrollViewComponent(5), (AUIBaseActor)base.GetItem(6).GetOwner(), new Func<RouletteAssemblyGridItem>(this.OnGridProxyCreate), false);
		}

		// Token: 0x06032B02 RID: 207618 RVA: 0x00BD3600 File Offset: 0x00BD1800
		private int GetGridRelativeIndex(AssemblyGridData gridData)
		{
			RouletteGridBase gridByValidId = this.RouletteComponent.GetGridByValidId(gridData.Id);
			if (gridByValidId != null)
			{
				return gridByValidId.Data.GridIndex + 1;
			}
			return 0;
		}

		// Token: 0x06032B03 RID: 207619 RVA: 0x00BD3634 File Offset: 0x00BD1834
		private void RefreshScrollView(bool keepSelect = false)
		{
			if (this.CurrentSelectOnGridData == null)
			{
				Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "未收到选中轮盘格子数据,无法刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			ERouletteGridType gridType = this.CurrentSelectOnGridData.GridType;
			List<AssemblyGridData> list2;
			List<AssemblyGridData> list = this.ViewProxy.AssemblyGridDataMap.TryGetValue(gridType, out list2) ? list2 : new List<AssemblyGridData>();
			List<AssemblyGridData> list3 = new List<AssemblyGridData>();
			for (int i = 0; i < list.Count; i++)
			{
				AssemblyGridData assemblyGridData = list[i];
				if (gridType != ERouletteGridType.EquipItem || (list[i] as AssemblyEquipItemGridData).ItemType == this.EquipItemType)
				{
					assemblyGridData.State = this.JudgeAssemblyGridState(list[i], this.CurrentSelectOnGridData);
					assemblyGridData.RelativeIndex = this.GetGridRelativeIndex(list[i]);
					list3.Add(assemblyGridData);
				}
			}
			this.TempKeepSelect = keepSelect;
			this.RefreshItemFilterSort(30, list3);
		}

		// Token: 0x06032B04 RID: 207620 RVA: 0x00BD371C File Offset: 0x00BD191C
		private void RefreshScrollViewByData(int selectGridIndex, List<AssemblyGridData> newDataList)
		{
			this.CurrentSelectOnAssemblyData = null;
			this.AssemblyGridScrollView.DeselectCurrentGridProxy(false);
			base.GetLoopScrollViewComponent(5).RootUIComp.Get().SetUIActive(newDataList.Count > 0);
			base.GetItem(9).SetUIActive(newDataList.Count <= 0);
			if (newDataList.Count > 0)
			{
				this.AssemblyGridScrollView.ReloadData(newDataList, false);
				this.AssemblyGridScrollView.ScrollToGridIndex(selectGridIndex, true);
				this.AssemblyGridScrollView.SelectGridProxy(selectGridIndex, true);
				this.SelectAssemblyGridIndex = selectGridIndex;
				return;
			}
			this.SelectAssemblyGridIndex = -1;
			if (Info.Instance.IsInGamepad())
			{
				this.AssemblyState = EAssemblyState.RouletteGridChoose;
			}
			this.AssemblyTips.SetActive(false);
			this.RefreshSwitchButton();
			ButtonItem buttonPhantomEdit = this.ButtonPhantomEdit;
			if (buttonPhantomEdit == null)
			{
				return;
			}
			buttonPhantomEdit.SetUiActive(false);
		}

		// Token: 0x06032B05 RID: 207621 RVA: 0x00BD37EC File Offset: 0x00BD19EC
		private void OnRouletteNavigationComponentEmit()
		{
			if (!this.AssemblyGridScrollView.IsGridDisplaying(this.SelectAssemblyGridIndex))
			{
				return;
			}
			RouletteAssemblyGridItem rouletteAssemblyGridItem = this.AssemblyGridScrollView.UnsafeGetGridProxy(this.SelectAssemblyGridIndex, false);
			UUIItem uuiitem = (rouletteAssemblyGridItem != null) ? rouletteAssemblyGridItem.GetRootItem() : null;
			if (uuiitem != null)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, true, true, true);
			}
		}

		// Token: 0x06032B06 RID: 207622 RVA: 0x00BD3840 File Offset: 0x00BD1A40
		private EAssemblyGridState JudgeAssemblyGridState(AssemblyGridData assemblyData, RouletteData rouletteData)
		{
			EAssemblyGridState result = EAssemblyGridState.UnEquip;
			List<int> list = new List<int>();
			if (rouletteData.GridType == ERouletteGridType.EquipItem)
			{
				list.Add(this.ViewProxy.CurrentRouletteListSaveData.ExtraItemId);
			}
			else
			{
				list = this.ViewProxy.CurrentRouletteListSaveData.RouletteIdList;
			}
			if (list.Contains(assemblyData.Id))
			{
				result = EAssemblyGridState.Equipped;
			}
			if (assemblyData.Id == rouletteData.Id)
			{
				result = EAssemblyGridState.CurrentChoose;
			}
			return result;
		}

		// Token: 0x06032B07 RID: 207623 RVA: 0x00BD38A8 File Offset: 0x00BD1AA8
		private RouletteAssemblyGridItem OnGridProxyCreate()
		{
			RouletteAssemblyGridItem rouletteAssemblyGridItem = new RouletteAssemblyGridItem();
			rouletteAssemblyGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.GridToggleFunction));
			return rouletteAssemblyGridItem;
		}

		// Token: 0x06032B08 RID: 207624 RVA: 0x00BD38C4 File Offset: 0x00BD1AC4
		private void GridToggleFunction(MediumItemGridExtendCallback callbackParameter)
		{
			int state = (int)callbackParameter.State;
			AssemblyGridData assemblyGridData = (AssemblyGridData)callbackParameter.Data;
			RouletteAssemblyGridItem rouletteAssemblyGridItem = (RouletteAssemblyGridItem)callbackParameter.MediumItemGrid;
			if (state == 1)
			{
				int selectedGridIndex = this.AssemblyGridScrollView.GetSelectedGridIndex();
				this.CurrentSelectOnAssemblyData = assemblyGridData;
				this.AssemblyGridScrollView.DeselectCurrentGridProxy(false);
				this.AssemblyGridScrollView.SelectGridProxy(assemblyGridData.Index, false);
				this.AssemblyGridScrollView.RefreshGridProxy(selectedGridIndex);
				this.RefreshSwitchButton();
				this.RefreshTips();
				if (RouletteModel.Instance.TryRemoveNewItem(this.CurrentSelectOnAssemblyData.Id))
				{
					this.AssemblyGridScrollView.RefreshGridProxy(rouletteAssemblyGridItem.GridIndex);
				}
			}
		}

		// Token: 0x06032B09 RID: 207625 RVA: 0x00BD3964 File Offset: 0x00BD1B64
		private void RefreshSwitchButton()
		{
			base.GetItem(14).SetUIActive(false);
			if (this.CurrentSelectOnAssemblyData != null)
			{
				if (this.CurrentSelectOnAssemblyData.GridType == ERouletteGridType.Explore)
				{
					ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(this.CurrentSelectOnAssemblyData.Id);
					if (exploreConfigById == null)
					{
						return;
					}
					if (!RouletteController.Instance.CheckCanExploreSkillEquip(this.CurrentSelectOnAssemblyData.Id) || !exploreConfigById.Value.AssemblyEquipButton)
					{
						this.ButtonSwitch.SetActive(false);
						base.GetItem(14).SetUIActive(true);
						return;
					}
				}
				string showText = null;
				switch (this.CurrentSelectOnAssemblyData.State)
				{
				case EAssemblyGridState.UnEquip:
					showText = "Text_PhantomPutOn_Text";
					break;
				case EAssemblyGridState.Equipped:
					showText = "Text_PhantomReplace_Text";
					break;
				case EAssemblyGridState.CurrentChoose:
					showText = "Text_PhantomTakeOff_Text";
					break;
				}
				this.ButtonSwitch.SetShowText(showText);
				this.ButtonSwitch.SetActive(true);
				return;
			}
			this.ButtonSwitch.SetActive(false);
			ButtonItem buttonPhantomEdit = this.ButtonPhantomEdit;
			if (buttonPhantomEdit == null)
			{
				return;
			}
			buttonPhantomEdit.SetUiActive(false);
		}

		// Token: 0x06032B0A RID: 207626 RVA: 0x00BD3A68 File Offset: 0x00BD1C68
		private void SelectedItem(int _)
		{
			AssemblyGridData currentSelectOnAssemblyData = this.CurrentSelectOnAssemblyData;
			RouletteData rouletteData = this.CurrentSelectOnGridData.DeepCopy();
			bool keepSelect = currentSelectOnAssemblyData.State == EAssemblyGridState.CurrentChoose;
			switch (currentSelectOnAssemblyData.State)
			{
			case EAssemblyGridState.UnEquip:
				rouletteData.Id = currentSelectOnAssemblyData.Id;
				rouletteData.State = EGridBehavior.Normal;
				if (currentSelectOnAssemblyData.GridType == ERouletteGridType.Explore)
				{
					int id = this.CurrentSelectOnGridData.Id;
					if (id != 0)
					{
						RouletteModel.Instance.SendExploreToolEquipLogData(id, 0, (int)this.ViewProxy.CurrentRouletteType, null);
					}
					RouletteModel.Instance.SendExploreToolEquipLogData(currentSelectOnAssemblyData.Id, 1, (int)this.ViewProxy.CurrentRouletteType, null);
				}
				else if (currentSelectOnAssemblyData.GridType == ERouletteGridType.EquipItem)
				{
					int id2 = this.CurrentSelectOnGridData.Id;
					if (id2 != 0)
					{
						RouletteModel.Instance.SendExploreToolEquipLogData(3001, 0, (int)this.ViewProxy.CurrentRouletteType, new int?(id2));
					}
					RouletteModel.Instance.SendExploreToolEquipLogData(3001, 1, (int)this.ViewProxy.CurrentRouletteType, new int?(currentSelectOnAssemblyData.Id));
				}
				break;
			case EAssemblyGridState.Equipped:
			{
				rouletteData.Id = currentSelectOnAssemblyData.Id;
				rouletteData.State = EGridBehavior.Normal;
				RouletteGridBase gridByValidId = this.RouletteComponent.GetGridByValidId(currentSelectOnAssemblyData.Id);
				RouletteData data = gridByValidId.Data;
				data.Id = this.CurrentSelectOnGridData.Id;
				if (this.CurrentSelectOnGridData.Id == 0)
				{
					data.State = EGridBehavior.CanAdd;
					data.Name = null;
				}
				else
				{
					data.State = EGridBehavior.Normal;
				}
				gridByValidId.RefreshGrid(data);
				int dataIndex = data.DataIndex;
				this.SaveTempDataMap(dataIndex, data);
				break;
			}
			case EAssemblyGridState.CurrentChoose:
				rouletteData.Id = 0;
				rouletteData.Name = null;
				rouletteData.State = EGridBehavior.CanAdd;
				if (currentSelectOnAssemblyData.GridType == ERouletteGridType.Explore)
				{
					RouletteModel.Instance.SendExploreToolEquipLogData(currentSelectOnAssemblyData.Id, 0, (int)this.ViewProxy.CurrentRouletteType, null);
				}
				else if (currentSelectOnAssemblyData.GridType == ERouletteGridType.EquipItem)
				{
					RouletteModel.Instance.SendExploreToolEquipLogData(3001, 0, (int)this.ViewProxy.CurrentRouletteType, new int?(currentSelectOnAssemblyData.Id));
				}
				break;
			}
			this.RouletteComponent.RefreshCurrentGridData(rouletteData);
			int dataIndex2 = this.CurrentSelectOnGridData.DataIndex;
			this.SaveTempDataMap(dataIndex2, rouletteData);
			this.CurrentSelectOnGridData = rouletteData;
			this.RefreshScrollView(keepSelect);
			this.RefreshSwitchButton();
			this.SaveTempData();
		}

		// Token: 0x06032B0B RID: 207627 RVA: 0x00BD3CCC File Offset: 0x00BD1ECC
		private void SaveTempDataMap(int dataIndex, RouletteData newData)
		{
			if (newData.GridType == ERouletteGridType.EquipItem)
			{
				this.ViewProxy.CurrentRouletteListSaveData.ExtraItemId = newData.Id;
				return;
			}
			List<int> rouletteIdList = this.ViewProxy.CurrentRouletteListSaveData.RouletteIdList;
			if (0 <= dataIndex && dataIndex < rouletteIdList.Count)
			{
				rouletteIdList[dataIndex] = newData.Id;
			}
		}

		// Token: 0x06032B0C RID: 207628 RVA: 0x00BD3D24 File Offset: 0x00BD1F24
		protected void RefreshItemFilterSort(int useWayId, List<AssemblyGridData> itemDataList)
		{
			this.SortEntrance.UpdateData((EFilterSortGroupId)useWayId, itemDataList, Array.Empty<object>());
			this.SortEntrance.SetActive(false);
		}

		// Token: 0x06032B0D RID: 207629 RVA: 0x00BD3D44 File Offset: 0x00BD1F44
		private void OnItemFilterSortRefresh(List<AssemblyGridData> list, bool isOutSideChange, EFilterSortType sortType)
		{
			int selectGridIndex = 0;
			if (this.TempKeepSelect)
			{
				selectGridIndex = this.AssemblyGridScrollView.GetSelectedGridIndex();
				this.TempKeepSelect = false;
			}
			else
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].State == EAssemblyGridState.CurrentChoose)
					{
						selectGridIndex = i;
					}
				}
			}
			int? openParamSelectId = this.ViewProxy.OpenParam.SelectGridId;
			if (openParamSelectId != null)
			{
				int num = list.FindIndex((AssemblyGridData item) => item.Id == openParamSelectId.Value);
				if (num != -1)
				{
					selectGridIndex = num;
				}
			}
			this.RefreshScrollViewByData(selectGridIndex, list);
		}

		// Token: 0x06032B0E RID: 207630 RVA: 0x00BD3DE4 File Offset: 0x00BD1FE4
		public void RefreshTips()
		{
			ERouletteGridType gridType = this.CurrentSelectOnAssemblyData.GridType;
			AssemblyTipsData assemblyTipsData = null;
			switch (gridType)
			{
			case ERouletteGridType.Explore:
				this.AssemblyTips.SetActive(true);
				assemblyTipsData = this.CreateExploreSkillTipsData(this.CurrentSelectOnAssemblyData);
				break;
			case ERouletteGridType.Function:
			{
				this.AssemblyTips.SetActive(false);
				ButtonItem buttonPhantomEdit = this.ButtonPhantomEdit;
				if (buttonPhantomEdit == null)
				{
					return;
				}
				buttonPhantomEdit.SetUiActive(false);
				return;
			}
			case ERouletteGridType.EquipItem:
				this.AssemblyTips.SetActive(true);
				assemblyTipsData = this.CreateEquipItemTipsData(this.CurrentSelectOnAssemblyData);
				break;
			}
			this.AssemblyTips.Refresh(assemblyTipsData);
			ButtonItem buttonPhantomEdit2 = this.ButtonPhantomEdit;
			if (buttonPhantomEdit2 == null)
			{
				return;
			}
			buttonPhantomEdit2.SetUiActive(assemblyTipsData.ShowPhantomInteractEquipment);
		}

		// Token: 0x06032B0F RID: 207631 RVA: 0x00BD3E88 File Offset: 0x00BD2088
		private AssemblyTipsData CreateExploreSkillTipsData(AssemblyGridData gridData)
		{
			AssemblyTipsData assemblyTipsData = new AssemblyTipsData();
			ExploreTools value = RouletteConfig.Instance.GetExploreConfigById(gridData.Id).Value;
			assemblyTipsData.GridType = ERouletteGridType.Explore;
			assemblyTipsData.GridId = gridData.Id;
			assemblyTipsData.TextMain = value.CurrentSkillInfo;
			assemblyTipsData.IsIconTexture = false;
			assemblyTipsData.IconPath = value.BackGround;
			assemblyTipsData.HelpId = value.HelpId;
			assemblyTipsData.Title = gridData.Name;
			assemblyTipsData.CanSetItemNum = RouletteModel.Instance.GetExploreSkillShowSetNumById((ERouletteExploreId)gridData.Id);
			assemblyTipsData.NeedItemMap = value.Cost();
			assemblyTipsData.ShowPhantomInteractEquipment = PhantomInteractModel.Instance.CheckIsPhantomInteractExploreTool(gridData.Id);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (KeyValuePair<int, int> keyValuePair in value.Authorization())
			{
				hashSet.Add(keyValuePair.Value);
			}
			assemblyTipsData.Authorization = new List<int>(hashSet);
			return assemblyTipsData;
		}

		// Token: 0x06032B10 RID: 207632 RVA: 0x00BD3FA0 File Offset: 0x00BD21A0
		private AssemblyTipsData CreateEquipItemTipsData(AssemblyGridData gridData)
		{
			AssemblyTipsData assemblyTipsData = new AssemblyTipsData();
			ItemInfo value = InventoryConfig.Instance.GetItemConfig(gridData.Id).Value;
			assemblyTipsData.GridType = ERouletteGridType.EquipItem;
			assemblyTipsData.GridId = gridData.Id;
			assemblyTipsData.BgQuality = (InventoryDefine.EQuality)value.QualityId;
			assemblyTipsData.Title = gridData.Name;
			assemblyTipsData.TextMain = value.AttributesDescription;
			assemblyTipsData.TextSub = value.BgDescription;
			if (value.ItemAccessLength > 0)
			{
				int[] itemAccessArray = value.GetItemAccessArray();
				for (int i = 0; i < itemAccessArray.Length; i++)
				{
					int getWayId = itemAccessArray[i];
					AccessPath? configById = GetWayConfig.Instance.GetConfigById(getWayId);
					if (configById != null)
					{
						GetWayItemData item = new GetWayItemData(getWayId, (EGetWayItemType)configById.Value.Type, configById.Value.Description, configById.Value.SortIndex, delegate()
						{
							SkipTaskManager.RunByConfigId(getWayId, gridData.Id);
						});
						assemblyTipsData.GetWayData.Add(item);
					}
				}
			}
			return assemblyTipsData;
		}

		// Token: 0x06032B11 RID: 207633 RVA: 0x00BD40F0 File Offset: 0x00BD22F0
		private void RefreshTabToggle()
		{
			if (this.CurrentSelectOnGridData == null)
			{
				Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "未收到选中轮盘格子数据,无法刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool flag = this.CurrentSelectOnGridData.GridType == ERouletteGridType.EquipItem;
			base.GetItem(2).SetUIActive(flag);
			if (flag)
			{
				InventoryDefine.EItemType eitemType = this.EquipItemType;
				int id = this.CurrentSelectOnGridData.Id;
				if (id != 0)
				{
					eitemType = (SpecialItemController.Instance.IsSpecialItem(id) ? InventoryDefine.EItemType.SpecialItem : InventoryDefine.EItemType.Common);
					this.EquipItemType = eitemType;
				}
				if (eitemType == InventoryDefine.EItemType.Common)
				{
					this.ToggleLeft.SetToggleState(EToggleState.ETT_Checked, false, false, false);
					return;
				}
				this.ToggleRight.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}

		// Token: 0x06032B12 RID: 207634 RVA: 0x00BD4196 File Offset: 0x00BD2396
		private bool CanTabToggleChanged(EToggleState state, InventoryDefine.EItemType type)
		{
			return state == EToggleState.ETT_UnChecked || this.EquipItemType != type;
		}

		// Token: 0x06032B13 RID: 207635 RVA: 0x00BD41A9 File Offset: 0x00BD23A9
		private void OnToggleLeftClicked(EToggleState state)
		{
			this.OnToggleClicked(InventoryDefine.EItemType.Common, state);
		}

		// Token: 0x06032B14 RID: 207636 RVA: 0x00BD41B3 File Offset: 0x00BD23B3
		private void OnToggleRightClicked(EToggleState state)
		{
			this.OnToggleClicked(InventoryDefine.EItemType.SpecialItem, state);
		}

		// Token: 0x06032B15 RID: 207637 RVA: 0x00BD41BE File Offset: 0x00BD23BE
		private void OnToggleClicked(InventoryDefine.EItemType newItemType, EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			if (this.EquipItemType == newItemType)
			{
				return;
			}
			this.EquipItemType = newItemType;
			((this.EquipItemType == InventoryDefine.EItemType.Common) ? this.ToggleRight : this.ToggleLeft).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshScrollView(false);
		}

		// Token: 0x06032B16 RID: 207638 RVA: 0x00BD41FE File Offset: 0x00BD23FE
		private void OnSaveDataChange()
		{
			this.UpdateButtonEnable();
		}

		// Token: 0x06032B17 RID: 207639 RVA: 0x00BD4206 File Offset: 0x00BD2406
		private void UpdateButtonEnable()
		{
			this.RefreshSwitchButton();
		}

		// Token: 0x06032B18 RID: 207640 RVA: 0x00BD4210 File Offset: 0x00BD2410
		private void SetExploreSkill()
		{
			ERouletteExploreId? endSwitchSkillId = this.ViewProxy.OpenParam.EndSwitchSkillId;
			if (endSwitchSkillId == null)
			{
				return;
			}
			CharacterExploreModel.Instance.SetExploreSkillId((int)endSwitchSkillId.Value, EExploreSkillLayer.Roulette, "RouletteAssemblyView.SetExploreSkill");
			RouletteController.Instance.ExploreSkillSetRequest((int)endSwitchSkillId.Value, null, false);
		}

		// Token: 0x06032B19 RID: 207641 RVA: 0x00BD4264 File Offset: 0x00BD2464
		private void SaveTempData()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "保存当前轮盘数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", this.ViewProxy.CurrentRouletteType);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			RouletteController.Instance.SaveRouletteDataRequest(this.ViewProxy.CurrentRouletteListSaveData, delegate(bool success)
			{
				if (!success)
				{
					this.OnRouletteTypeSwitch((int)this.ViewProxy.CurrentRouletteType);
				}
			});
		}

		// Token: 0x06032B1A RID: 207642 RVA: 0x00BD42C8 File Offset: 0x00BD24C8
		private void OnToggleConfigClicked(EToggleState state)
		{
			int config = (state == EToggleState.ETT_Checked) ? 1 : 0;
			RouletteModel.Instance.SaveRouletteSelectConfig(config);
		}

		// Token: 0x06032B1B RID: 207643 RVA: 0x00BD42E5 File Offset: 0x00BD24E5
		private void OnPhantomEditClicked(int _)
		{
			PhantomInteractController.Instance.OpenPhantomVisionEditView(0, false);
		}

		// Token: 0x0401AFC3 RID: 110531
		private RouletteAssemblyViewProxy ViewProxy;

		// Token: 0x0401AFC4 RID: 110532
		[Nullable(2)]
		private RouletteInputBase InputManager;

		// Token: 0x0401AFC5 RID: 110533
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> AssemblyGridScrollView;

		// Token: 0x0401AFC6 RID: 110534
		private InventoryDefine.EItemType EquipItemType = InventoryDefine.EItemType.Common;

		// Token: 0x0401AFC7 RID: 110535
		[Nullable(2)]
		protected UUIExtendToggle ToggleLeft;

		// Token: 0x0401AFC8 RID: 110536
		[Nullable(2)]
		protected UUIExtendToggle ToggleRight;

		// Token: 0x0401AFC9 RID: 110537
		[Nullable(2)]
		private RouletteData CurrentSelectOnGridData;

		// Token: 0x0401AFCA RID: 110538
		[Nullable(2)]
		private AssemblyGridData CurrentSelectOnAssemblyData;

		// Token: 0x0401AFCB RID: 110539
		private EAssemblyState ViewAssemblyState;

		// Token: 0x0401AFCC RID: 110540
		[Nullable(2)]
		private ButtonItem ButtonSwitch;

		// Token: 0x0401AFCD RID: 110541
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401AFCE RID: 110542
		[Nullable(2)]
		private RouletteAssemblyTips AssemblyTips;

		// Token: 0x0401AFCF RID: 110543
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<AssemblyGridData> SortEntrance;

		// Token: 0x0401AFD0 RID: 110544
		private bool IsFirstShow = true;

		// Token: 0x0401AFD1 RID: 110545
		[Nullable(2)]
		private RouletteAssemblyTabItem TabItem;

		// Token: 0x0401AFD2 RID: 110546
		[Nullable(2)]
		public UUIItem RouletteUiItem;

		// Token: 0x0401AFD3 RID: 110547
		[Nullable(2)]
		private ButtonItem ButtonPhantomEdit;

		// Token: 0x0401AFD4 RID: 110548
		protected int SelectAssemblyGridIndex;

		// Token: 0x0401AFD5 RID: 110549
		protected bool TempKeepSelect;
	}
}
