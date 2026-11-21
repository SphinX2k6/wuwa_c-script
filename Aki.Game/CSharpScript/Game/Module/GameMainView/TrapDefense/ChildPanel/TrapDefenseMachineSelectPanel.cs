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
	// Token: 0x020049DF RID: 18911
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMachineSelectPanel : BattleChildViewPanel
	{
		// Token: 0x0602F563 RID: 193891 RVA: 0x00D3447C File Offset: 0x00D3267C
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

		// Token: 0x0602F564 RID: 193892 RVA: 0x00D34504 File Offset: 0x00D32704
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

		// Token: 0x0602F565 RID: 193893 RVA: 0x00D34550 File Offset: 0x00D32750
		private UniTask InitMachineItemList()
		{
			TrapDefenseMachineSelectPanel.<InitMachineItemList>d__17 <InitMachineItemList>d__;
			<InitMachineItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMachineItemList>d__.<>4__this = this;
			<InitMachineItemList>d__.<>1__state = -1;
			<InitMachineItemList>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitMachineItemList>d__17>(ref <InitMachineItemList>d__);
			return <InitMachineItemList>d__.<>t__builder.Task;
		}

		// Token: 0x0602F566 RID: 193894 RVA: 0x00D34594 File Offset: 0x00D32794
		private UniTask InitMoneyIcon()
		{
			TrapDefenseMachineSelectPanel.<InitMoneyIcon>d__18 <InitMoneyIcon>d__;
			<InitMoneyIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoneyIcon>d__.<>4__this = this;
			<InitMoneyIcon>d__.<>1__state = -1;
			<InitMoneyIcon>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitMoneyIcon>d__18>(ref <InitMoneyIcon>d__);
			return <InitMoneyIcon>d__.<>t__builder.Task;
		}

		// Token: 0x0602F567 RID: 193895 RVA: 0x00D345D8 File Offset: 0x00D327D8
		private UniTask InitTouchSlider()
		{
			TrapDefenseMachineSelectPanel.<InitTouchSlider>d__19 <InitTouchSlider>d__;
			<InitTouchSlider>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTouchSlider>d__.<>4__this = this;
			<InitTouchSlider>d__.<>1__state = -1;
			<InitTouchSlider>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitTouchSlider>d__19>(ref <InitTouchSlider>d__);
			return <InitTouchSlider>d__.<>t__builder.Task;
		}

		// Token: 0x0602F568 RID: 193896 RVA: 0x00D3461C File Offset: 0x00D3281C
		public override void InitializeTemp()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.LastMoneyNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
			this.MoneyText = base.GetText(1);
			this.MoneyTween = new LguiIntTween();
			this.MoneyTween.BindUpdateTween(new Action<int>(this.OnMoneyTweenUpdate));
		}

		// Token: 0x0602F569 RID: 193897 RVA: 0x00D34680 File Offset: 0x00D32880
		public override UniTask InitializeAsync()
		{
			TrapDefenseMachineSelectPanel.<InitializeAsync>d__21 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<TrapDefenseMachineSelectPanel.<InitializeAsync>d__21>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F56A RID: 193898 RVA: 0x00D346C3 File Offset: 0x00D328C3
		protected override void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseOnSystemInfoNotify, new Action(this.OnTrapDefenseSystemInfoNotify));
		}

		// Token: 0x0602F56B RID: 193899 RVA: 0x00D346E1 File Offset: 0x00D328E1
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnSystemInfoNotify, new Action(this.OnTrapDefenseSystemInfoNotify));
		}

		// Token: 0x0602F56C RID: 193900 RVA: 0x00D346FF File Offset: 0x00D328FF
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			this.RefreshMachineState();
			this.RegisterBehaviorTreeVar();
			this.RefreshMachineSelectCollapse();
		}

		// Token: 0x0602F56D RID: 193901 RVA: 0x00D34713 File Offset: 0x00D32913
		protected override void OnHideBattleChildViewPanel()
		{
			this.UnregisterBehaviorTreeVar();
		}

		// Token: 0x0602F56E RID: 193902 RVA: 0x00D3471C File Offset: 0x00D3291C
		public override void OnTickBattleChildViewPanel(float delta)
		{
			foreach (TrapDefenseMachineSelectItem trapDefenseMachineSelectItem in this.ItemList)
			{
				trapDefenseMachineSelectItem.Tick(delta);
			}
		}

		// Token: 0x0602F56F RID: 193903 RVA: 0x00D34770 File Offset: 0x00D32970
		protected override void OnBeforeDestroy()
		{
			this.MoneyTween.Destroy();
			this.Sequence.Clear();
		}

		// Token: 0x0602F570 RID: 193904 RVA: 0x00D34788 File Offset: 0x00D32988
		private void OnTrapDefenseSystemInfoNotify()
		{
			this.RefreshTouchSlider();
		}

		// Token: 0x0602F571 RID: 193905 RVA: 0x00D34790 File Offset: 0x00D32990
		private void RegisterBehaviorTreeVar()
		{
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.EventRefreshMoneyText));
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.TrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.MaxTrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
		}

		// Token: 0x0602F572 RID: 193906 RVA: 0x00D347F4 File Offset: 0x00D329F4
		private void UnregisterBehaviorTreeVar()
		{
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.EventRefreshMoneyText));
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.TrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.MaxTrapCount, new TTreeVarUpdateDelegate(this.EventRefreshBuildText));
		}

		// Token: 0x0602F573 RID: 193907 RVA: 0x00D34855 File Offset: 0x00D32A55
		private void HandleMachineSelect(TrapDefenseMachineSelectItem selectItem)
		{
			this.SetCurrentSelectItem(selectItem);
			this.HandleCurrentSelectItem();
		}

		// Token: 0x0602F574 RID: 193908 RVA: 0x00D34864 File Offset: 0x00D32A64
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

		// Token: 0x0602F575 RID: 193909 RVA: 0x00D34898 File Offset: 0x00D32A98
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

		// Token: 0x0602F576 RID: 193910 RVA: 0x00D34936 File Offset: 0x00D32B36
		private void OpenOrganDevelop(TrapDefenseMachineSelectItem selectItem)
		{
			TrapDefenseController.Instance.OpenOrganDevelop(true, null, selectItem.Index, null);
		}

		// Token: 0x0602F577 RID: 193911 RVA: 0x00D3494C File Offset: 0x00D32B4C
		private void RefreshMachineSelectCollapse()
		{
			bool machineSelectCollapse = UiManager.Instance.IsViewShow(EUiViewName.PlotViewHUD);
			this.SetMachineSelectCollapse(machineSelectCollapse);
		}

		// Token: 0x0602F578 RID: 193912 RVA: 0x00D34970 File Offset: 0x00D32B70
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

		// Token: 0x0602F579 RID: 193913 RVA: 0x00D349B2 File Offset: 0x00D32BB2
		protected void EventRefreshMoneyText([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			this.RefreshMoneyText();
		}

		// Token: 0x0602F57A RID: 193914 RVA: 0x00D349BC File Offset: 0x00D32BBC
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

		// Token: 0x0602F57B RID: 193915 RVA: 0x00D34A78 File Offset: 0x00D32C78
		protected void EventRefreshBuildText([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			this.RefreshBuildText();
		}

		// Token: 0x0602F57C RID: 193916 RVA: 0x00D34A80 File Offset: 0x00D32C80
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

		// Token: 0x0602F57D RID: 193917 RVA: 0x00D34AD8 File Offset: 0x00D32CD8
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

		// Token: 0x0602F57E RID: 193918 RVA: 0x00D34B35 File Offset: 0x00D32D35
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

		// Token: 0x0602F57F RID: 193919 RVA: 0x00D34B60 File Offset: 0x00D32D60
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

		// Token: 0x0602F580 RID: 193920 RVA: 0x00D34BB4 File Offset: 0x00D32DB4
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

		// Token: 0x0602F581 RID: 193921 RVA: 0x00D34C83 File Offset: 0x00D32E83
		private void OnMoneyTweenUpdate(int value)
		{
			this.MoneyText.SetText(value.ToString(), true);
			this.LastMoneyNum = (long)value;
		}

		// Token: 0x0602F582 RID: 193922 RVA: 0x00D34CA0 File Offset: 0x00D32EA0
		public void SetInterface(ITrapDefenseMachineSelectInterface machineSelectInterface)
		{
			this.MachineSelectInterface = machineSelectInterface;
		}

		// Token: 0x0602F583 RID: 193923 RVA: 0x00D34CA9 File Offset: 0x00D32EA9
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

		// Token: 0x0602F584 RID: 193924 RVA: 0x00D34CE8 File Offset: 0x00D32EE8
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

		// Token: 0x0602F585 RID: 193925 RVA: 0x00D34E0C File Offset: 0x00D3300C
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

		// Token: 0x0602F586 RID: 193926 RVA: 0x00D34F2C File Offset: 0x00D3312C
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

		// Token: 0x0602F587 RID: 193927 RVA: 0x00D34F98 File Offset: 0x00D33198
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

		// Token: 0x0602F588 RID: 193928 RVA: 0x00D35010 File Offset: 0x00D33210
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

		// Token: 0x04019198 RID: 102808
		private const float TWEEN_NUM_INTERVAL = 0.01f;

		// Token: 0x04019199 RID: 102809
		private const float TWEEN_MAX_TIME = 0.5f;

		// Token: 0x0401919A RID: 102810
		protected List<TrapDefenseMachineSelectItem> ItemList = new List<TrapDefenseMachineSelectItem>();

		// Token: 0x0401919B RID: 102811
		[Nullable(2)]
		protected TrapDefenseMachineSelectItem CurrentSelectItem;

		// Token: 0x0401919C RID: 102812
		[Nullable(2)]
		protected ITrapDefenseMachineSelectInterface MachineSelectInterface;

		// Token: 0x0401919D RID: 102813
		[Nullable(2)]
		protected TrapDefenseMachineSelectSlider TouchSlider;

		// Token: 0x0401919E RID: 102814
		protected LguiIntTween MoneyTween;

		// Token: 0x0401919F RID: 102815
		protected UUIText MoneyText;

		// Token: 0x040191A0 RID: 102816
		protected long LastMoneyNum;

		// Token: 0x040191A1 RID: 102817
		[Nullable(2)]
		protected TrapDefenseMachineSelectItem SliderRecordLastSelectItem;

		// Token: 0x040191A2 RID: 102818
		[Nullable(2)]
		protected TrapDefenseMachineSelectItem SliderRecordDragSelectItem;

		// Token: 0x040191A3 RID: 102819
		protected UiSequencePlayer Sequence;

		// Token: 0x040191A4 RID: 102820
		protected bool IsInPlotHud;

		// Token: 0x040191A5 RID: 102821
		protected bool IsInitialized;

		// Token: 0x0200A658 RID: 42584
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x040336C6 RID: 210630
			public const int LayoutRootItem = 0;

			// Token: 0x040336C7 RID: 210631
			public const int MoneyText = 1;

			// Token: 0x040336C8 RID: 210632
			public const int BuildText = 2;

			// Token: 0x040336C9 RID: 210633
			public const int MoneyIcon = 3;

			// Token: 0x040336CA RID: 210634
			public const int TouchSliderItem = 4;
		}
	}
}
