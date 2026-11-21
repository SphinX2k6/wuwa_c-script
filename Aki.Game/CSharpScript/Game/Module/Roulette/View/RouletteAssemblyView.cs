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
	// Token: 0x02003C4F RID: 15439
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteAssemblyView : UiTickViewBase
	{
		// Token: 0x170050B4 RID: 20660
		// (get) Token: 0x0602789A RID: 161946 RVA: 0x00B1761F File Offset: 0x00B1581F
		private RouletteComponentAssembly RouletteComponent
		{
			get
			{
				return this.ViewProxy.GetRouletteComponent();
			}
		}

		// Token: 0x0602789B RID: 161947 RVA: 0x00B1762C File Offset: 0x00B1582C
		public RouletteAssemblyView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602789C RID: 161948 RVA: 0x00B17644 File Offset: 0x00B15844
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
			int num = 20;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
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

		// Token: 0x0602789D RID: 161949 RVA: 0x00B179D4 File Offset: 0x00B15BD4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
			EventSystem.Instance.Add<RouletteData>(EEventName.OnRouletteItemSelect, new Action<RouletteData>(this.OnRouletteButtonClicked));
			EventSystem.Instance.Add(EEventName.OnRouletteSaveDataChange, new Action(this.OnSaveDataChange));
			EventSystem.Instance.Add(EEventName.OnRouletteItemUnlock, new Action(this.OnButtonSwitch));
			EventSystem.Instance.Add(EEventName.RouletteNavigationComponentEmit, new Action(this.OnRouletteNavigationComponentEmit));
		}

		// Token: 0x0602789E RID: 161950 RVA: 0x00B17A70 File Offset: 0x00B15C70
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.OnRouletteItemSelect, new Action<RouletteData>(this.OnRouletteButtonClicked));
			EventSystem.Instance.Remove(EEventName.OnRouletteSaveDataChange, new Action(this.OnSaveDataChange));
			EventSystem.Instance.Remove(EEventName.OnRouletteItemUnlock, new Action(this.OnButtonSwitch));
			EventSystem.Instance.Remove(EEventName.RouletteNavigationComponentEmit, new Action(this.OnRouletteNavigationComponentEmit));
		}

		// Token: 0x0602789F RID: 161951 RVA: 0x00B17B0C File Offset: 0x00B15D0C
		protected override UniTask OnBeforeStartAsync()
		{
			RouletteAssemblyView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RouletteAssemblyView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060278A0 RID: 161952 RVA: 0x00B17B4F File Offset: 0x00B15D4F
		protected override void OnStart()
		{
			this.InitRouletteInputManager();
			this.ViewProxy.Start();
		}

		// Token: 0x060278A1 RID: 161953 RVA: 0x00B17B64 File Offset: 0x00B15D64
		protected override void OnBeforeDestroy()
		{
			this.SetExploreSkill();
			RouletteModel.Instance.SaveNewItemList();
			if (this.InputManager != null)
			{
				this.InputManager.Destroy();
				this.InputManager = null;
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

		// Token: 0x060278A2 RID: 161954 RVA: 0x00B17BEC File Offset: 0x00B15DEC
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

		// Token: 0x060278A3 RID: 161955 RVA: 0x00B17C8A File Offset: 0x00B15E8A
		protected override void OnAfterHide()
		{
			ButtonItem buttonPhantomEdit = this.ButtonPhantomEdit;
			if (buttonPhantomEdit == null)
			{
				return;
			}
			buttonPhantomEdit.UnBindGivenUid(0);
		}

		// Token: 0x060278A4 RID: 161956 RVA: 0x00B17CA0 File Offset: 0x00B15EA0
		protected override void OnTick(float delta)
		{
			ValueTuple<int?, int?> valueTuple = this.InputManager.Tick(delta);
			int? item = valueTuple.Item1;
			int? item2 = valueTuple.Item2;
			this.RouletteComponent.Refresh(item, item2);
		}

		// Token: 0x060278A5 RID: 161957 RVA: 0x00B17CD3 File Offset: 0x00B15ED3
		private void OnRouletteTypeSwitch(int typeId)
		{
			this.ViewProxy.OnRouletteTypeSwitch((ERouletteType)typeId);
			this.RefreshTypeSwitch();
		}

		// Token: 0x060278A6 RID: 161958 RVA: 0x00B17CE8 File Offset: 0x00B15EE8
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

		// Token: 0x170050B5 RID: 20661
		// (get) Token: 0x060278A7 RID: 161959 RVA: 0x00B17D3D File Offset: 0x00B15F3D
		// (set) Token: 0x060278A8 RID: 161960 RVA: 0x00B17D48 File Offset: 0x00B15F48
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

		// Token: 0x060278A9 RID: 161961 RVA: 0x00B17E5C File Offset: 0x00B1605C
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
			UUIItem gridAndScrollToByJudge = this.GetAssemblyGridScrollView(this.CurrentSelectOnGridData.GridType).GetGridAndScrollToByJudge(num2, (object itemIdObj, AssemblyGridData data) => (int)itemIdObj == data.Id, true);
			if (gridAndScrollToByJudge != null)
			{
				return new UUIItem[]
				{
					gridAndScrollToByJudge,
					gridAndScrollToByJudge
				};
			}
			return null;
		}

		// Token: 0x060278AA RID: 161962 RVA: 0x00B17EFD File Offset: 0x00B160FD
		private void SetRouletteType()
		{
			this.RouletteComponent.RefreshRouletteType();
		}

		// Token: 0x060278AB RID: 161963 RVA: 0x00B17F0A File Offset: 0x00B1610A
		private void SetRoulettePlatformType()
		{
			this.RouletteComponent.RefreshRoulettePlatformType();
		}

		// Token: 0x060278AC RID: 161964 RVA: 0x00B17F18 File Offset: 0x00B16118
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

		// Token: 0x060278AD RID: 161965 RVA: 0x00B17F8F File Offset: 0x00B1618F
		private void SwitchInputType()
		{
			this.SetRouletteInputType();
			this.InitRouletteInputManager();
			this.AssemblyState = EAssemblyState.RouletteGridChoose;
			this.SelectDefaultRouletteGrid();
		}

		// Token: 0x060278AE RID: 161966 RVA: 0x00B17FAC File Offset: 0x00B161AC
		private void OnButtonSwitch()
		{
			EAssemblyState assemblyState = (this.AssemblyState == EAssemblyState.RouletteGridChoose) ? EAssemblyState.ScrollViewChoose : EAssemblyState.RouletteGridChoose;
			this.AssemblyState = assemblyState;
		}

		// Token: 0x060278AF RID: 161967 RVA: 0x00B17FD0 File Offset: 0x00B161D0
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

		// Token: 0x060278B0 RID: 161968 RVA: 0x00B18018 File Offset: 0x00B16218
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

		// Token: 0x060278B1 RID: 161969 RVA: 0x00B180B4 File Offset: 0x00B162B4
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

		// Token: 0x060278B2 RID: 161970 RVA: 0x00B181A0 File Offset: 0x00B163A0
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

		// Token: 0x060278B3 RID: 161971 RVA: 0x00B18234 File Offset: 0x00B16434
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

		// Token: 0x060278B4 RID: 161972 RVA: 0x00B1827C File Offset: 0x00B1647C
		private void InitScrollView()
		{
			this.ItemAssemblyGridScrollView = new LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData>(base.GetLoopScrollViewComponent(5), (AUIBaseActor)base.GetItem(6).GetOwner(), new Func<RouletteAssemblyGridItem>(this.OnGridProxyCreate), false);
			this.GeneralAssemblyGridScrollView = new LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData>(base.GetLoopScrollViewComponent(17), (AUIBaseActor)base.GetItem(19).GetOwner(), new Func<RouletteAssemblyGridItem>(this.OnGridProxyCreate), false);
		}

		// Token: 0x060278B5 RID: 161973 RVA: 0x00B182EB File Offset: 0x00B164EB
		private LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> GetAssemblyGridScrollView(ERouletteGridType gridType)
		{
			if (gridType != ERouletteGridType.EquipItem)
			{
				return this.GeneralAssemblyGridScrollView;
			}
			return this.ItemAssemblyGridScrollView;
		}

		// Token: 0x060278B6 RID: 161974 RVA: 0x00B18300 File Offset: 0x00B16500
		private int GetGridRelativeIndex(AssemblyGridData gridData)
		{
			RouletteGridBase gridByValidId = this.RouletteComponent.GetGridByValidId(gridData.Id);
			if (gridByValidId != null)
			{
				return gridByValidId.Data.GridIndex + 1;
			}
			return 0;
		}

		// Token: 0x060278B7 RID: 161975 RVA: 0x00B18334 File Offset: 0x00B16534
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

		// Token: 0x060278B8 RID: 161976 RVA: 0x00B1841C File Offset: 0x00B1661C
		private void RefreshScrollViewByData(ERouletteGridType gridType, int selectGridIndex, List<AssemblyGridData> newDataList)
		{
			LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> assemblyGridScrollView = this.GetAssemblyGridScrollView(gridType);
			bool flag = gridType == ERouletteGridType.EquipItem;
			this.CurrentSelectOnAssemblyData = null;
			assemblyGridScrollView.DeselectCurrentGridProxy(false);
			base.GetItem(18).SetUIActive(flag);
			base.GetLoopScrollViewComponent(5).RootUIComp.Get().SetUIActive(flag && newDataList.Count > 0);
			base.GetLoopScrollViewComponent(17).RootUIComp.Get().SetUIActive(!flag && newDataList.Count > 0);
			base.GetItem(9).SetUIActive(newDataList.Count <= 0);
			if (newDataList.Count > 0)
			{
				if (flag)
				{
					this.GeneralAssemblyGridScrollView.RefreshByData(Array.Empty<AssemblyGridData>(), false, null, false);
				}
				else
				{
					this.ItemAssemblyGridScrollView.RefreshByData(Array.Empty<AssemblyGridData>(), false, null, false);
				}
				assemblyGridScrollView.ReloadData(newDataList, false);
				assemblyGridScrollView.ScrollToGridIndex(selectGridIndex, true);
				assemblyGridScrollView.SelectGridProxy(selectGridIndex, true);
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

		// Token: 0x060278B9 RID: 161977 RVA: 0x00B18550 File Offset: 0x00B16750
		private void OnRouletteNavigationComponentEmit()
		{
			LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> assemblyGridScrollView = this.GetAssemblyGridScrollView(this.CurrentSelectOnGridData.GridType);
			if (!assemblyGridScrollView.IsGridDisplaying(this.SelectAssemblyGridIndex))
			{
				return;
			}
			RouletteAssemblyGridItem rouletteAssemblyGridItem = assemblyGridScrollView.UnsafeGetGridProxy(this.SelectAssemblyGridIndex, false);
			UUIItem uuiitem = (rouletteAssemblyGridItem != null) ? rouletteAssemblyGridItem.GetRootItem() : null;
			if (uuiitem != null)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, true, true, true);
			}
		}

		// Token: 0x060278BA RID: 161978 RVA: 0x00B185AC File Offset: 0x00B167AC
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

		// Token: 0x060278BB RID: 161979 RVA: 0x00B18614 File Offset: 0x00B16814
		private RouletteAssemblyGridItem OnGridProxyCreate()
		{
			RouletteAssemblyGridItem rouletteAssemblyGridItem = new RouletteAssemblyGridItem();
			rouletteAssemblyGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.GridToggleFunction));
			return rouletteAssemblyGridItem;
		}

		// Token: 0x060278BC RID: 161980 RVA: 0x00B18630 File Offset: 0x00B16830
		private void GridToggleFunction(MediumItemGridExtendCallback callbackParameter)
		{
			int state = (int)callbackParameter.State;
			AssemblyGridData assemblyGridData = (AssemblyGridData)callbackParameter.Data;
			RouletteAssemblyGridItem rouletteAssemblyGridItem = (RouletteAssemblyGridItem)callbackParameter.MediumItemGrid;
			if (state == 1)
			{
				LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> assemblyGridScrollView = this.GetAssemblyGridScrollView(assemblyGridData.GridType);
				int selectedGridIndex = assemblyGridScrollView.GetSelectedGridIndex();
				this.CurrentSelectOnAssemblyData = assemblyGridData;
				assemblyGridScrollView.DeselectCurrentGridProxy(false);
				assemblyGridScrollView.SelectGridProxy(assemblyGridData.Index, false);
				assemblyGridScrollView.RefreshGridProxy(selectedGridIndex);
				this.RefreshSwitchButton();
				this.RefreshTips();
				if (RouletteModel.Instance.TryRemoveNewItem(this.CurrentSelectOnAssemblyData.Id))
				{
					assemblyGridScrollView.RefreshGridProxy(rouletteAssemblyGridItem.GridIndex);
				}
			}
		}

		// Token: 0x060278BD RID: 161981 RVA: 0x00B186C4 File Offset: 0x00B168C4
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

		// Token: 0x060278BE RID: 161982 RVA: 0x00B187C8 File Offset: 0x00B169C8
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

		// Token: 0x060278BF RID: 161983 RVA: 0x00B18A2C File Offset: 0x00B16C2C
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

		// Token: 0x060278C0 RID: 161984 RVA: 0x00B18A84 File Offset: 0x00B16C84
		protected void RefreshItemFilterSort(int useWayId, List<AssemblyGridData> itemDataList)
		{
			this.SortEntrance.UpdateData((EFilterSortGroupId)useWayId, itemDataList, Array.Empty<object>());
			this.SortEntrance.SetActive(false);
		}

		// Token: 0x060278C1 RID: 161985 RVA: 0x00B18AA4 File Offset: 0x00B16CA4
		private void OnItemFilterSortRefresh(List<AssemblyGridData> list, bool isOutSideChange, EFilterSortType sortType)
		{
			int selectGridIndex = 0;
			ERouletteGridType gridType = this.CurrentSelectOnGridData.GridType;
			LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> assemblyGridScrollView = this.GetAssemblyGridScrollView(gridType);
			if (this.TempKeepSelect)
			{
				selectGridIndex = assemblyGridScrollView.GetSelectedGridIndex();
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
			this.RefreshScrollViewByData(gridType, selectGridIndex, list);
		}

		// Token: 0x060278C2 RID: 161986 RVA: 0x00B18B5C File Offset: 0x00B16D5C
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

		// Token: 0x060278C3 RID: 161987 RVA: 0x00B18C00 File Offset: 0x00B16E00
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

		// Token: 0x060278C4 RID: 161988 RVA: 0x00B18D18 File Offset: 0x00B16F18
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

		// Token: 0x060278C5 RID: 161989 RVA: 0x00B18E68 File Offset: 0x00B17068
		private void RefreshTabToggle()
		{
			if (this.CurrentSelectOnGridData == null)
			{
				Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "未收到选中轮盘格子数据,无法刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool flag = this.CurrentSelectOnGridData.GridType == ERouletteGridType.EquipItem;
			base.GetItem(18).SetUIActive(flag);
			base.GetLoopScrollViewComponent(17).RootUIComp.Get().SetUIActive(!flag);
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

		// Token: 0x060278C6 RID: 161990 RVA: 0x00B18F30 File Offset: 0x00B17130
		private bool CanTabToggleChanged(EToggleState state, InventoryDefine.EItemType type)
		{
			return state == EToggleState.ETT_UnChecked || this.EquipItemType != type;
		}

		// Token: 0x060278C7 RID: 161991 RVA: 0x00B18F43 File Offset: 0x00B17143
		private void OnToggleLeftClicked(EToggleState state)
		{
			this.OnToggleClicked(InventoryDefine.EItemType.Common, state);
		}

		// Token: 0x060278C8 RID: 161992 RVA: 0x00B18F4D File Offset: 0x00B1714D
		private void OnToggleRightClicked(EToggleState state)
		{
			this.OnToggleClicked(InventoryDefine.EItemType.SpecialItem, state);
		}

		// Token: 0x060278C9 RID: 161993 RVA: 0x00B18F58 File Offset: 0x00B17158
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

		// Token: 0x060278CA RID: 161994 RVA: 0x00B18F98 File Offset: 0x00B17198
		private void OnSaveDataChange()
		{
			this.UpdateButtonEnable();
		}

		// Token: 0x060278CB RID: 161995 RVA: 0x00B18FA0 File Offset: 0x00B171A0
		private void UpdateButtonEnable()
		{
			this.RefreshSwitchButton();
		}

		// Token: 0x060278CC RID: 161996 RVA: 0x00B18FA8 File Offset: 0x00B171A8
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

		// Token: 0x060278CD RID: 161997 RVA: 0x00B18FFC File Offset: 0x00B171FC
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

		// Token: 0x060278CE RID: 161998 RVA: 0x00B19060 File Offset: 0x00B17260
		private void OnToggleConfigClicked(EToggleState state)
		{
			int config = (state == EToggleState.ETT_Checked) ? 1 : 0;
			RouletteModel.Instance.SaveRouletteSelectConfig(config);
		}

		// Token: 0x060278CF RID: 161999 RVA: 0x00B1907D File Offset: 0x00B1727D
		private void OnPhantomEditClicked(int _)
		{
			PhantomInteractController.Instance.OpenPhantomVisionEditView(0, false);
		}

		// Token: 0x04015923 RID: 88355
		private RouletteAssemblyViewProxy ViewProxy;

		// Token: 0x04015924 RID: 88356
		[Nullable(2)]
		private RouletteInputBase InputManager;

		// Token: 0x04015925 RID: 88357
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> ItemAssemblyGridScrollView;

		// Token: 0x04015926 RID: 88358
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RouletteAssemblyGridItem, AssemblyGridData> GeneralAssemblyGridScrollView;

		// Token: 0x04015927 RID: 88359
		private InventoryDefine.EItemType EquipItemType = InventoryDefine.EItemType.Common;

		// Token: 0x04015928 RID: 88360
		[Nullable(2)]
		protected UUIExtendToggle ToggleLeft;

		// Token: 0x04015929 RID: 88361
		[Nullable(2)]
		protected UUIExtendToggle ToggleRight;

		// Token: 0x0401592A RID: 88362
		[Nullable(2)]
		private RouletteData CurrentSelectOnGridData;

		// Token: 0x0401592B RID: 88363
		[Nullable(2)]
		private AssemblyGridData CurrentSelectOnAssemblyData;

		// Token: 0x0401592C RID: 88364
		private EAssemblyState ViewAssemblyState;

		// Token: 0x0401592D RID: 88365
		[Nullable(2)]
		private ButtonItem ButtonSwitch;

		// Token: 0x0401592E RID: 88366
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401592F RID: 88367
		[Nullable(2)]
		private RouletteAssemblyTips AssemblyTips;

		// Token: 0x04015930 RID: 88368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<AssemblyGridData> SortEntrance;

		// Token: 0x04015931 RID: 88369
		private bool IsFirstShow = true;

		// Token: 0x04015932 RID: 88370
		[Nullable(2)]
		private RouletteAssemblyTabItem TabItem;

		// Token: 0x04015933 RID: 88371
		[Nullable(2)]
		public UUIItem RouletteUiItem;

		// Token: 0x04015934 RID: 88372
		[Nullable(2)]
		private ButtonItem ButtonPhantomEdit;

		// Token: 0x04015935 RID: 88373
		protected int SelectAssemblyGridIndex;

		// Token: 0x04015936 RID: 88374
		protected bool TempKeepSelect;
	}
}
