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

// Token: 0x020011FE RID: 4606
public class TrapDefensePreparationPanel : BattleChildViewPanel
{
	// Token: 0x0600B6FE RID: 46846 RVA: 0x00360DD8 File Offset: 0x0035EFD8
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

	// Token: 0x0600B6FF RID: 46847 RVA: 0x00360E85 File Offset: 0x0035F085
	protected override void OnStart()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B700 RID: 46848 RVA: 0x00360E98 File Offset: 0x0035F098
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("UiIn", false, false);
		this.RefreshShopItemActive();
		this.RefreshWeaponPreparationBtnActive();
	}

	// Token: 0x0600B701 RID: 46849 RVA: 0x00360EB8 File Offset: 0x0035F0B8
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefensePreparationPanel.<OnBeforeHideAsync>d__5 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefensePreparationPanel.<OnBeforeHideAsync>d__5>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B702 RID: 46850 RVA: 0x00360EFB File Offset: 0x0035F0FB
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600B703 RID: 46851 RVA: 0x00360F19 File Offset: 0x0035F119
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600B704 RID: 46852 RVA: 0x00360F37 File Offset: 0x0035F137
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600B705 RID: 46853 RVA: 0x00360F44 File Offset: 0x0035F144
	private void OnStartChallengeBtnClicked()
	{
		if (this.CheckShowConfirmBox())
		{
			this.ShowConfirmBox();
			return;
		}
		this.StartFight();
	}

	// Token: 0x0600B706 RID: 46854 RVA: 0x00360F5C File Offset: 0x0035F15C
	protected override bool OnCheckBattleChildViewPanelShowCondition()
	{
		return TowerDefenseEventController.Instance.IsInPreview();
	}

	// Token: 0x0600B707 RID: 46855 RVA: 0x00360F68 File Offset: 0x0035F168
	private void OnWeaponPreparationBtnClicked()
	{
		TrapDefenseController.Instance.OpenOrganDevelop(true, null, 0, null);
	}

	// Token: 0x0600B708 RID: 46856 RVA: 0x00360F78 File Offset: 0x0035F178
	private void OnShopBtnClicked()
	{
		TrapDefenseModel.Instance.OpenViewShop();
	}

	// Token: 0x0600B709 RID: 46857 RVA: 0x00360F84 File Offset: 0x0035F184
	private void OnWorldDoneAndCloseLoading()
	{
		this.RefreshShopItemActive();
		this.RefreshWeaponPreparationBtnActive();
	}

	// Token: 0x0600B70A RID: 46858 RVA: 0x00360F94 File Offset: 0x0035F194
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

	// Token: 0x0600B70B RID: 46859 RVA: 0x00361008 File Offset: 0x0035F208
	private bool CheckShowConfirmBox()
	{
		int isCanBuildMachine = TrapDefenseModel.Instance.BattleData.IsCanBuildMachine ? 1 : 0;
		bool isSkipMachineFullCheck = TrapDefenseModel.Instance.IsSkipMachineFullCheck;
		return isCanBuildMachine != 0 && !isSkipMachineFullCheck && !TrapDefenseModel.Instance.ViewModelBuildingDevelop.IsSlotFull();
	}

	// Token: 0x0600B70C RID: 46860 RVA: 0x0036104C File Offset: 0x0035F24C
	private UniTask StartFight()
	{
		TrapDefensePreparationPanel.<StartFight>d__16 <StartFight>d__;
		<StartFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartFight>d__.<>1__state = -1;
		<StartFight>d__.<>t__builder.Start<TrapDefensePreparationPanel.<StartFight>d__16>(ref <StartFight>d__);
		return <StartFight>d__.<>t__builder.Task;
	}

	// Token: 0x0600B70D RID: 46861 RVA: 0x00361088 File Offset: 0x0035F288
	public void RefreshShopItemActive()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(TrapDefenseModel.Instance.BattleData.IsShopOpen);
	}

	// Token: 0x0600B70E RID: 46862 RVA: 0x003610C4 File Offset: 0x0035F2C4
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

	// Token: 0x040069B9 RID: 27065
	[Nullable(1)]
	protected UiSequencePlayer Sequence;

	// Token: 0x020074D9 RID: 29913
	private static class EComponentDefine
	{
		// Token: 0x0402602B RID: 155691
		public const int StartChallengeBtn = 0;

		// Token: 0x0402602C RID: 155692
		public const int WeaponPreparationBtn = 1;

		// Token: 0x0402602D RID: 155693
		public const int ShopBtn = 2;
	}
}
