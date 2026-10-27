using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D3C RID: 7484
public class TrapDefensePreparationPanel : BattleChildViewPanel
{
	// Token: 0x0600E2E1 RID: 58081 RVA: 0x003553A8 File Offset: 0x003535A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnStartChallengeBtnClicked)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnWeaponPreparationBtnClicked)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnShopBtnClicked))
		};
	}

	// Token: 0x0600E2E2 RID: 58082 RVA: 0x00355455 File Offset: 0x00353655
	protected override void OnStart()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600E2E3 RID: 58083 RVA: 0x00355468 File Offset: 0x00353668
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("UiIn", false, false);
		this.RefreshShopItemActive();
		this.RefreshWeaponPreparationBtnActive();
	}

	// Token: 0x0600E2E4 RID: 58084 RVA: 0x00355488 File Offset: 0x00353688
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefensePreparationPanel.<OnBeforeHideAsync>d__5 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefensePreparationPanel.<OnBeforeHideAsync>d__5>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E2E5 RID: 58085 RVA: 0x003554CB File Offset: 0x003536CB
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600E2E6 RID: 58086 RVA: 0x003554E9 File Offset: 0x003536E9
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600E2E7 RID: 58087 RVA: 0x00355507 File Offset: 0x00353707
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600E2E8 RID: 58088 RVA: 0x00355514 File Offset: 0x00353714
	private void OnStartChallengeBtnClicked()
	{
		if (this.CheckShowConfirmBox())
		{
			this.ShowConfirmBox();
			return;
		}
		this.StartFight();
	}

	// Token: 0x0600E2E9 RID: 58089 RVA: 0x0035552C File Offset: 0x0035372C
	protected override bool OnCheckBattleChildViewPanelShowCondition()
	{
		return TowerDefenseEventController.Instance.IsInPreview();
	}

	// Token: 0x0600E2EA RID: 58090 RVA: 0x00355538 File Offset: 0x00353738
	private void OnWeaponPreparationBtnClicked()
	{
		TrapDefenseController.Instance.OpenOrganDevelop(true, null, 0, null);
	}

	// Token: 0x0600E2EB RID: 58091 RVA: 0x00355548 File Offset: 0x00353748
	private void OnShopBtnClicked()
	{
		TrapDefenseModel.Instance.OpenViewShop();
	}

	// Token: 0x0600E2EC RID: 58092 RVA: 0x00355554 File Offset: 0x00353754
	private void OnWorldDoneAndCloseLoading()
	{
		this.RefreshShopItemActive();
		this.RefreshWeaponPreparationBtnActive();
	}

	// Token: 0x0600E2ED RID: 58093 RVA: 0x00355564 File Offset: 0x00353764
	private void ShowConfirmBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TrapDefenseMachineFull);
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleTextKey = "ConfirmBox_363_Desc";
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
		{
			TrapDefenseModel.Instance.IsSkipMachineFullCheck = isSelectOn;
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.StartFight();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600E2EE RID: 58094 RVA: 0x003555D8 File Offset: 0x003537D8
	private bool CheckShowConfirmBox()
	{
		int isCanBuildMachine = TrapDefenseModel.Instance.BattleData.IsCanBuildMachine ? 1 : 0;
		bool isSkipMachineFullCheck = TrapDefenseModel.Instance.IsSkipMachineFullCheck;
		return isCanBuildMachine != 0 && !isSkipMachineFullCheck && !TrapDefenseModel.Instance.ViewModelBuildingDevelop.IsSlotFull();
	}

	// Token: 0x0600E2EF RID: 58095 RVA: 0x0035561C File Offset: 0x0035381C
	private UniTask StartFight()
	{
		TrapDefensePreparationPanel.<StartFight>d__16 <StartFight>d__;
		<StartFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartFight>d__.<>1__state = -1;
		<StartFight>d__.<>t__builder.Start<TrapDefensePreparationPanel.<StartFight>d__16>(ref <StartFight>d__);
		return <StartFight>d__.<>t__builder.Task;
	}

	// Token: 0x0600E2F0 RID: 58096 RVA: 0x00355658 File Offset: 0x00353858
	public void RefreshShopItemActive()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(TrapDefenseModel.Instance.BattleData.IsShopOpen);
	}

	// Token: 0x0600E2F1 RID: 58097 RVA: 0x00355694 File Offset: 0x00353894
	public void RefreshWeaponPreparationBtnActive()
	{
		bool isCanBuildMachine = TrapDefenseModel.Instance.BattleData.IsCanBuildMachine;
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(isCanBuildMachine);
	}

	// Token: 0x040068DA RID: 26842
	[Nullable(1)]
	protected UiSequencePlayer Sequence;

	// Token: 0x02008350 RID: 33616
	private static class EComponentDefine
	{
		// Token: 0x0402AD03 RID: 175363
		public const int StartChallengeBtn = 0;

		// Token: 0x0402AD04 RID: 175364
		public const int WeaponPreparationBtn = 1;

		// Token: 0x0402AD05 RID: 175365
		public const int ShopBtn = 2;
	}
}
