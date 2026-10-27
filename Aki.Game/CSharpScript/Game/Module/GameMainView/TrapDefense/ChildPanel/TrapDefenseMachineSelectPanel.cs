using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense.ChildPanel
{
	// Token: 0x02005A03 RID: 23043
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMachineSelectPanel : BattleChildViewPanel
	{
		// Token: 0x0603A61A RID: 239130 RVA: 0x00DE3F2C File Offset: 0x00DE212C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x0603A61B RID: 239131 RVA: 0x00DE3FB4 File Offset: 0x00DE21B4
		private UniTask CreateMachineItem(UUIItem uiItem)
		{
			TrapDefenseMachineSelectPanel.<CreateMachineItem>d__16 <CreateMachineItem>d__;
			<CreateMachineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMachineItem>d__.<>4__this = this;
			<CreateMachineItem>d__.uiItem = uiItem;
			<CreateMachineItem>d__.<>1__state = -1;
			<CreateMachineItem>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<CreateMachineItem>d__16>(ref <CreateMachineItem>d__);
			return <CreateMachineItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603A61C RID: 239132 RVA: 0x00DE4000 File Offset: 0x00DE2200
		private UniTask InitMachineItemList()
		{
			TrapDefenseMachineSelectPanel.<InitMachineItemList>d__17 <InitMachineItemList>d__;
			<InitMachineItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMachineItemList>d__.<>4__this = this;
			<InitMachineItemList>d__.<>1__state = -1;
			<InitMachineItemList>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitMachineItemList>d__17>(ref <InitMachineItemList>d__);
			return <InitMachineItemList>d__.<>t__builder.Task;
		}

		// Token: 0x0603A61D RID: 239133 RVA: 0x00DE4044 File Offset: 0x00DE2244
		private UniTask InitMoneyIcon()
		{
			TrapDefenseMachineSelectPanel.<InitMoneyIcon>d__18 <InitMoneyIcon>d__;
			<InitMoneyIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoneyIcon>d__.<>4__this = this;
			<InitMoneyIcon>d__.<>1__state = -1;
			<InitMoneyIcon>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitMoneyIcon>d__18>(ref <InitMoneyIcon>d__);
			return <InitMoneyIcon>d__.<>t__builder.Task;
		}

		// Token: 0x0603A61E RID: 239134 RVA: 0x00DE4088 File Offset: 0x00DE2288
		private UniTask InitTouchSlider()
		{
			TrapDefenseMachineSelectPanel.<InitTouchSlider>d__19 <InitTouchSlider>d__;
			<InitTouchSlider>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTouchSlider>d__.<>4__this = this;
			<InitTouchSlider>d__.<>1__state = -1;
			<InitTouchSlider>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitTouchSlider>d__19>(ref <InitTouchSlider>d__);
			return <InitTouchSlider>d__.<>t__builder.Task;
		}

		// Token: 0x0603A61F RID: 239135 RVA: 0x00DE40CC File Offset: 0x00DE22CC
		public override void InitializeTemp()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.LastMoneyNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
			this.MoneyText = base.GetText(1);
			this.MoneyTween = new LguiIntTween();
			this.MoneyTween.BindUpdateTween(new Action<int>(this.OnMoneyTweenUpdate));
		}

		// Token: 0x0603A620 RID: 239136 RVA: 0x00DE4130 File Offset: 0x00DE2330
		public override UniTask InitializeAsync()
		{
			TrapDefenseMachineSelectPanel.<InitializeAsync>d__21 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitializeAsync>d__21>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A621 RID: 239137 RVA: 0x00DE4173 File Offset: 0x00DE2373
		protected override void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseOnSystemInfoNotify, new Action(this.OnTrapDefenseSystemInfoNotify));
		}

		// Token: 0x0603A622 RID: 239138 RVA: 0x00DE4191 File Offset: 0x00DE2391
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnSystemInfoNotify, new Action(this.OnTrapDefenseSystemInfoNotify));
		}

		// Token: 0x0603A623 RID: 239139 RVA: 0x00DE41AF File Offset: 0x00DE23AF
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			this.RefreshMachineState();
			this.RegisterBehaviorTreeVar();
			this.RefreshMachineSelectCollapse();
		}

		// Token: 0x0603A624 RID: 239140 RVA: 0x00DE41C3 File Offset: 0x00DE23C3
		protected override void OnHideBattleChildViewPanel()
		{
			this.UnregisterBehaviorTreeVar();
		}

		// Token: 0x0603A625 RID: 239141 RVA: 0x00DE41CC File Offset: 0x00DE23CC
		public override void OnTickBattleChildViewPanel(float delta)
		{
			foreach (TrapDefenseMachineSelectItem trapDefenseMachineSelectItem in this.ItemList)
			{
				trapDefenseMachineSelectItem.Tick(delta);
			}
		}

		// Token: 0x0603A626 RID: 239142 RVA: 0x00DE4220 File Offset: 0x00DE2420
		protected override void OnBeforeDestroy()
		{
			this.MoneyTween.Destroy();
			this.Sequence.Clear();
		}

		// Token: 0x0603A627 RID: 239143 RVA: 0x00DE4238 File Offset: 0x00DE2438
		private void OnTrapDefenseSystemInfoNotify()
		{
			this.RefreshTouchSlider();
		}

		// Token: 0x0603A628 RID: 239144 RVA: 0x00DE4240 File Offset: 0x00DE2440
		private void RegisterBehaviorTreeVar()
		{
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.EventRefreshMoneyText));
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.TrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.MaxTrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
		}

		// Token: 0x0603A629 RID: 239145 RVA: 0x00DE42A4 File Offset: 0x00DE24A4
		private void UnregisterBehaviorTreeVar()
		{
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.EventRefreshMoneyText));
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.TrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.MaxTrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
		}

		// Token: 0x0603A62A RID: 239146 RVA: 0x00DE4305 File Offset: 0x00DE2505
		private void HandleMachineSelect(TrapDefenseMachineSelectItem selectItem)
		{
			this.SetCurrentSelectItem(selectItem);
			this.HandleCurrentSelectItem();
		}

		// Token: 0x0603A62B RID: 239147 RVA: 0x00DE4314 File Offset: 0x00DE2514
		private void SetCurrentSelectItem(TrapDefenseMachineSelectItem selectItem)
		{
			if (selectItem.Data == null)
			{
				return;
			}
			if (this.CurrentSelectItem == selectItem)
			{
				return;
			}
			if (this.CurrentSelectItem != null)
			{
				this.CurrentSelectItem.SetToggleState(EToggleState.ETT_UnChecked, false);
			}
			this.CurrentSelectItem = selectItem;
		}

		// Token: 0x0603A62C RID: 239148 RVA: 0x00DE4348 File Offset: 0x00DE2548
		private void HandleCurrentSelectItem()
		{
			if (this.CurrentSelectItem == null || this.CurrentSelectItem.Data == null)
			{
				return;
			}
			if (this.CurrentSelectItem.Data.IsBuilding)
			{
				TowerDefenseEventController.Instance.HandleTowerDefenseSelect(this.CurrentSelectItem.Index);
				EventSystem.Instance.Emit<bool>(EEventName.OnPlayerFollowerEnableChange, false);
			}
			else
			{
				TowerDefensePlayerController.HandleTowerFollowerSelect(this.CurrentSelectItem.Data.Id);
				EventSystem.Instance.Emit<bool>(EEventName.OnPlayerFollowerEnableChange, true);
			}
			ITrapDefenseMachineSelectInterface machineSelectInterface = this.MachineSelectInterface;
			if (machineSelectInterface == null)
			{
				return;
			}
			machineSelectInterface.SelectMachine(this.CurrentSelectItem.Data);
		}

		// Token: 0x0603A62D RID: 239149 RVA: 0x00DE43E6 File Offset: 0x00DE25E6
		private void OpenOrganDevelop(TrapDefenseMachineSelectItem selectItem)
		{
			TrapDefenseController.Instance.OpenOrganDevelop(true, null, selectItem.Index, null);
		}

		// Token: 0x0603A62E RID: 239150 RVA: 0x00DE43FC File Offset: 0x00DE25FC
		private void RefreshMachineSelectCollapse()
		{
			bool machineSelectCollapse = UiManager.Instance.IsViewShow(EUiViewName.PlotViewHUD);
			this.SetMachineSelectCollapse(machineSelectCollapse);
		}

		// Token: 0x0603A62F RID: 239151 RVA: 0x00DE4420 File Offset: 0x00DE2620
		private void RefreshTouchSlider()
		{
			if (this.TouchSlider != null)
			{
				List<TrapDefenseBuildingSlotData> slotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData();
				if (slotData.Count > 0)
				{
					this.TouchSlider.RefreshSliderMaxValue((float)(slotData.Count - 1));
				}
			}
		}

		// Token: 0x0603A630 RID: 239152 RVA: 0x00DE4462 File Offset: 0x00DE2662
		protected void EventRefreshMoneyText([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			this.RefreshMoneyText();
		}

		// Token: 0x0603A631 RID: 239153 RVA: 0x00DE446C File Offset: 0x00DE266C
		protected void RefreshMoneyText()
		{
			long goldNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
			long num = Math.Abs(goldNum - this.LastMoneyNum);
			if (num > 0L)
			{
				float time = Math.Min((float)num * 0.01f, 0.5f);
				this.MoneyTween.PlayTween((int)this.LastMoneyNum, (int)goldNum, time, null);
			}
			else
			{
				this.MoneyTween.KillTween();
				this.MoneyText.SetText(goldNum.ToString(), true);
			}
			foreach (TrapDefenseMachineSelectItem trapDefenseMachineSelectItem in this.ItemList)
			{
				trapDefenseMachineSelectItem.RefreshCoin();
			}
		}

		// Token: 0x0603A632 RID: 239154 RVA: 0x00DE4528 File Offset: 0x00DE2728
		protected void EventRefreshBuildText([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			this.RefreshBuildText();
		}

		// Token: 0x0603A633 RID: 239155 RVA: 0x00DE4530 File Offset: 0x00DE2730
		protected void RefreshBuildText()
		{
			long trapCount = TrapDefenseModel.Instance.BattleData.GetTrapCount();
			long maxTrapCount = TrapDefenseModel.Instance.BattleData.GetMaxTrapCount();
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(trapCount.ToString() + "/" + maxTrapCount.ToString(), true);
		}

		// Token: 0x0603A634 RID: 239156 RVA: 0x00DE4588 File Offset: 0x00DE2788
		private void OnToggleClick(TrapDefenseMachineSelectItem selectItem)
		{
			if (selectItem.Data == null && TrapDefenseModel.Instance.BattleData.IsCanBuildMachine)
			{
				selectItem.SetToggleState(EToggleState.ETT_UnChecked, false);
				this.OpenOrganDevelop(selectItem);
				return;
			}
			this.HandleMachineSelect(selectItem);
			int num = this.ItemList.IndexOf(selectItem);
			TrapDefenseMachineSelectSlider touchSlider = this.TouchSlider;
			if (touchSlider == null)
			{
				return;
			}
			touchSlider.SetSliderValue((float)num, false);
		}

		// Token: 0x0603A635 RID: 239157 RVA: 0x00DE45E5 File Offset: 0x00DE27E5
		private void OnSliderPointerDown()
		{
			this.SliderRecordLastSelectItem = this.CurrentSelectItem;
			this.SliderRecordDragSelectItem = this.CurrentSelectItem;
			ITrapDefenseMachineSelectInterface machineSelectInterface = this.MachineSelectInterface;
			if (machineSelectInterface == null)
			{
				return;
			}
			machineSelectInterface.SliderPointerDown();
		}

		// Token: 0x0603A636 RID: 239158 RVA: 0x00DE4610 File Offset: 0x00DE2810
		private void OnSliderValueChange(float value)
		{
			TrapDefenseMachineSelectItem trapDefenseMachineSelectItem = this.ItemList[(int)value];
			trapDefenseMachineSelectItem.SetToggleState(EToggleState.ETT_Checked, false);
			TrapDefenseMachineSelectItem sliderRecordDragSelectItem = this.SliderRecordDragSelectItem;
			if (sliderRecordDragSelectItem != null)
			{
				sliderRecordDragSelectItem.SetToggleState(EToggleState.ETT_UnChecked, false);
			}
			this.SliderRecordDragSelectItem = trapDefenseMachineSelectItem;
			ITrapDefenseMachineSelectInterface machineSelectInterface = this.MachineSelectInterface;
			if (machineSelectInterface == null)
			{
				return;
			}
			machineSelectInterface.SliderValueChange(trapDefenseMachineSelectItem.Data);
		}

		// Token: 0x0603A637 RID: 239159 RVA: 0x00DE4664 File Offset: 0x00DE2864
		private void OnSliderEndDrag()
		{
			if (this.SliderRecordDragSelectItem != null)
			{
				if (this.SliderRecordDragSelectItem.Data == null)
				{
					this.SliderRecordDragSelectItem.SetToggleState(EToggleState.ETT_UnChecked, false);
					if (TrapDefenseModel.Instance.BattleData.IsCanBuildMachine)
					{
						this.OpenOrganDevelop(this.SliderRecordDragSelectItem);
					}
				}
				else
				{
					this.SliderRecordLastSelectItem = this.SliderRecordDragSelectItem;
				}
			}
			if (this.SliderRecordLastSelectItem != null)
			{
				if (this.SliderRecordLastSelectItem != this.CurrentSelectItem)
				{
					this.HandleMachineSelect(this.SliderRecordLastSelectItem);
				}
				else
				{
					this.SliderRecordLastSelectItem.SetToggleState(EToggleState.ETT_Checked, true);
					int num = this.ItemList.IndexOf(this.SliderRecordLastSelectItem);
					TrapDefenseMachineSelectSlider touchSlider = this.TouchSlider;
					if (touchSlider != null)
					{
						touchSlider.SetSliderValue((float)num, false);
					}
				}
			}
			this.SliderRecordDragSelectItem = null;
			this.SliderRecordLastSelectItem = null;
			ITrapDefenseMachineSelectInterface machineSelectInterface = this.MachineSelectInterface;
			if (machineSelectInterface == null)
			{
				return;
			}
			machineSelectInterface.SliderDragEnd();
		}

		// Token: 0x0603A638 RID: 239160 RVA: 0x00DE4733 File Offset: 0x00DE2933
		private void OnMoneyTweenUpdate(int value)
		{
			this.MoneyText.SetText(value.ToString(), true);
			this.LastMoneyNum = (long)value;
		}

		// Token: 0x0603A639 RID: 239161 RVA: 0x00DE4750 File Offset: 0x00DE2950
		public void SetInterface(ITrapDefenseMachineSelectInterface machineSelectInterface)
		{
			this.MachineSelectInterface = machineSelectInterface;
		}

		// Token: 0x0603A63A RID: 239162 RVA: 0x00DE4759 File Offset: 0x00DE2959
		public void OnTowerDefenseStepUpdate(ETowerDefenseEventProcessStatus status)
		{
			if (status == ETowerDefenseEventProcessStatus.Fighting)
			{
				this.TryResetToFirstAuxiliary();
				return;
			}
			if (status == ETowerDefenseEventProcessStatus.Ready && !this.IsInitialized)
			{
				this.IsInitialized = true;
				this.TryResetToFirstAuxiliary();
				return;
			}
			if (this.CurrentSelectItem == null)
			{
				this.RefreshMachineState();
				return;
			}
			this.RefreshSlotState();
		}

		// Token: 0x0603A63B RID: 239163 RVA: 0x00DE4798 File Offset: 0x00DE2998
		public void RefreshMachineState()
		{
			this.RefreshSlotState();
			TrapDefenseMachineSelectItem currentSelectItem = this.CurrentSelectItem;
			int? num;
			if (currentSelectItem == null)
			{
				num = null;
			}
			else
			{
				TrapDefenseBuildingDevelopItemData data = currentSelectItem.Data;
				num = ((data != null) ? new int?(data.Id) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			List<TrapDefenseBuildingSlotData> slotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData();
			if (slotData.Count > 0)
			{
				int num3 = -1;
				int num4 = -1;
				foreach (TrapDefenseBuildingSlotData trapDefenseBuildingSlotData in slotData)
				{
					TrapDefenseBuildingDevelopItemData slotData2 = trapDefenseBuildingSlotData.GetSlotData();
					if (slotData2 != null)
					{
						if (!slotData2.IsBuilding && num3 == -1)
						{
							num3 = trapDefenseBuildingSlotData.GetIndex();
						}
						if (slotData2.Id == valueOrDefault)
						{
							num4 = trapDefenseBuildingSlotData.GetIndex();
							break;
						}
					}
				}
				if (num4 != -1)
				{
					this.ItemList[num4].SetToggleState(EToggleState.ETT_Checked, true);
				}
				else if (num3 != -1)
				{
					this.ItemList[num3].SetToggleState(EToggleState.ETT_Checked, true);
				}
			}
			this.RefreshMoneyText();
			this.RefreshBuildText();
		}

		// Token: 0x0603A63C RID: 239164 RVA: 0x00DE48BC File Offset: 0x00DE2ABC
		private void TryResetToFirstAuxiliary()
		{
			this.RefreshSlotState();
			TrapDefenseMachineSelectItem currentSelectItem = this.CurrentSelectItem;
			int? num;
			if (currentSelectItem == null)
			{
				num = null;
			}
			else
			{
				TrapDefenseBuildingDevelopItemData data = currentSelectItem.Data;
				num = ((data != null) ? new int?(data.Id) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			List<TrapDefenseBuildingSlotData> slotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData();
			if (slotData.Count > 0)
			{
				int num3 = -1;
				int num4 = -1;
				foreach (TrapDefenseBuildingSlotData trapDefenseBuildingSlotData in slotData)
				{
					TrapDefenseBuildingDevelopItemData slotData2 = trapDefenseBuildingSlotData.GetSlotData();
					if (slotData2 != null && !slotData2.IsBuilding)
					{
						if (!slotData2.IsBuilding && num3 == -1)
						{
							num3 = trapDefenseBuildingSlotData.GetIndex();
						}
						if (slotData2.Id == valueOrDefault)
						{
							num4 = trapDefenseBuildingSlotData.GetIndex();
							break;
						}
					}
				}
				if (num4 != -1)
				{
					this.ItemList[num4].SetToggleState(EToggleState.ETT_Checked, true);
					return;
				}
				if (num3 != -1)
				{
					this.ItemList[num3].SetToggleState(EToggleState.ETT_Checked, true);
				}
			}
		}

		// Token: 0x0603A63D RID: 239165 RVA: 0x00DE49DC File Offset: 0x00DE2BDC
		public void RefreshMachineCdState(int proxyId)
		{
			foreach (TrapDefenseMachineSelectItem trapDefenseMachineSelectItem in this.ItemList)
			{
				TrapDefenseBuildingDevelopItemData data = trapDefenseMachineSelectItem.Data;
				if (data != null && data.Id == proxyId)
				{
					trapDefenseMachineSelectItem.RefreshCd();
				}
			}
		}

		// Token: 0x0603A63E RID: 239166 RVA: 0x00DE4A48 File Offset: 0x00DE2C48
		public void RefreshSlotState()
		{
			List<TrapDefenseBuildingSlotData> slotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData();
			int i = 0;
			int count = this.ItemList.Count;
			while (i < count)
			{
				TrapDefenseMachineSelectItem trapDefenseMachineSelectItem = this.ItemList[i];
				if (i < slotData.Count)
				{
					TrapDefenseBuildingSlotData trapDefenseBuildingSlotData = slotData[i];
					trapDefenseMachineSelectItem.Refresh(trapDefenseBuildingSlotData.GetSlotData());
					trapDefenseMachineSelectItem.SetActive(true);
				}
				else
				{
					trapDefenseMachineSelectItem.SetActive(false);
					trapDefenseMachineSelectItem.Refresh(null);
				}
				i++;
			}
		}

		// Token: 0x0603A63F RID: 239167 RVA: 0x00DE4AC0 File Offset: 0x00DE2CC0
		public void SetMachineSelectCollapse(bool isInPlotHud)
		{
			if (this.IsInPlotHud == isInPlotHud)
			{
				return;
			}
			this.IsInPlotHud = isInPlotHud;
			if (isInPlotHud)
			{
				this.Sequence.StopSequenceByKey("Normal", false, true);
				this.Sequence.PlaySequence("Collapse", false, null);
				return;
			}
			this.Sequence.StopSequenceByKey("Collapse", false, true);
			this.Sequence.PlaySequence("Normal", false, null);
		}

		// Token: 0x0401E6F1 RID: 124657
		private const float TWEEN_NUM_INTERVAL = 0.01f;

		// Token: 0x0401E6F2 RID: 124658
		private const float TWEEN_MAX_TIME = 0.5f;

		// Token: 0x0401E6F3 RID: 124659
		protected List<TrapDefenseMachineSelectItem> ItemList = new List<TrapDefenseMachineSelectItem>();

		// Token: 0x0401E6F4 RID: 124660
		[Nullable(2)]
		protected TrapDefenseMachineSelectItem CurrentSelectItem;

		// Token: 0x0401E6F5 RID: 124661
		[Nullable(2)]
		protected ITrapDefenseMachineSelectInterface MachineSelectInterface;

		// Token: 0x0401E6F6 RID: 124662
		[Nullable(2)]
		protected TrapDefenseMachineSelectSlider TouchSlider;

		// Token: 0x0401E6F7 RID: 124663
		protected LguiIntTween MoneyTween;

		// Token: 0x0401E6F8 RID: 124664
		protected UUIText MoneyText;

		// Token: 0x0401E6F9 RID: 124665
		protected long LastMoneyNum;

		// Token: 0x0401E6FA RID: 124666
		[Nullable(2)]
		protected TrapDefenseMachineSelectItem SliderRecordLastSelectItem;

		// Token: 0x0401E6FB RID: 124667
		[Nullable(2)]
		protected TrapDefenseMachineSelectItem SliderRecordDragSelectItem;

		// Token: 0x0401E6FC RID: 124668
		protected UiSequencePlayer Sequence;

		// Token: 0x0401E6FD RID: 124669
		protected bool IsInPlotHud;

		// Token: 0x0401E6FE RID: 124670
		protected bool IsInitialized;

		// Token: 0x0200BC4E RID: 48206
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04038CF9 RID: 232697
			public const int LayoutRootItem = 0;

			// Token: 0x04038CFA RID: 232698
			public const int MoneyText = 1;

			// Token: 0x04038CFB RID: 232699
			public const int BuildText = 2;

			// Token: 0x04038CFC RID: 232700
			public const int MoneyIcon = 3;

			// Token: 0x04038CFD RID: 232701
			public const int TouchSliderItem = 4;
		}
	}
}
