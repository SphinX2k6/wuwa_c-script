using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Module.TrapDefense;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D3D RID: 7485
[NullableContext(1)]
[Nullable(0)]
public abstract class TrapDefenseSkillPanelBase : BattleChildViewPanel
{
	// Token: 0x0600E2F4 RID: 58100 RVA: 0x003556E1 File Offset: 0x003538E1
	protected override void OnStart()
	{
		this.RefreshAllBattleSkillItems();
		this.OnChildStart();
	}

	// Token: 0x0600E2F5 RID: 58101 RVA: 0x003556F0 File Offset: 0x003538F0
	protected override void OnAfterShow()
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.RefreshEnable(true);
		}
	}

	// Token: 0x0600E2F6 RID: 58102 RVA: 0x00355744 File Offset: 0x00353944
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.RefreshSkillCoolDownOnShow();
		}
	}

	// Token: 0x0600E2F7 RID: 58103 RVA: 0x00355794 File Offset: 0x00353994
	protected override void OnHideBattleChildViewPanel()
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			if (battleSkillItem.IsShowOrShowing)
			{
				battleSkillItem.TryReleaseButton();
			}
		}
	}

	// Token: 0x0600E2F8 RID: 58104 RVA: 0x003557F0 File Offset: 0x003539F0
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (!this.Visible)
		{
			return;
		}
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.Tick(delta);
		}
	}

	// Token: 0x0600E2F9 RID: 58105 RVA: 0x0035584C File Offset: 0x00353A4C
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600E2FA RID: 58106 RVA: 0x003558C8 File Offset: 0x00353AC8
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600E2FB RID: 58107 RVA: 0x00355944 File Offset: 0x00353B44
	private void OnChangedTimeScale()
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.RefreshTimeDilation();
		}
	}

	// Token: 0x0600E2FC RID: 58108 RVA: 0x00355994 File Offset: 0x00353B94
	private void OnPauseGame(int flag)
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.PauseGame(flag);
		}
	}

	// Token: 0x0600E2FD RID: 58109 RVA: 0x003559E8 File Offset: 0x00353BE8
	private void OnSkillButtonSkillIdRefresh(ESkillButtonType buttonType)
	{
		this.RefreshSkillItemByButtonType(buttonType);
	}

	// Token: 0x0600E2FE RID: 58110 RVA: 0x003559F1 File Offset: 0x00353BF1
	private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
	{
		this.RefreshSkillItemByButtonType(buttonType);
	}

	// Token: 0x0600E2FF RID: 58111 RVA: 0x003559FC File Offset: 0x00353BFC
	private void RefreshAllBattleSkillItems()
	{
		string[] actionNameList = this.GetActionNameList();
		for (int i = 0; i < actionNameList.Length; i++)
		{
			string actionName = actionNameList[i];
			BattleSkillItem battleSkillItem = this.BattleSkillItemList[i];
			TrapDefenseBattleSkillData skillData = TrapDefenseModel.Instance.BattleData.GetSkillData(actionName);
			battleSkillItem.Refresh(skillData);
			this.DataMap[i] = skillData;
		}
	}

	// Token: 0x0600E300 RID: 58112 RVA: 0x00355A54 File Offset: 0x00353C54
	private void RefreshSkillItemByButtonType(ESkillButtonType buttonType)
	{
		string[] actionNameList = this.GetActionNameList();
		foreach (TrapDefenseBattleSkillData trapDefenseBattleSkillData in this.DataMap.Values)
		{
			if (trapDefenseBattleSkillData.GetButtonType() == buttonType)
			{
				int num = Array.IndexOf<string>(actionNameList, trapDefenseBattleSkillData.GetActionName());
				if (num >= 0)
				{
					this.BattleSkillItemList[num].Refresh(trapDefenseBattleSkillData);
				}
			}
		}
	}

	// Token: 0x0600E301 RID: 58113 RVA: 0x00355AD8 File Offset: 0x00353CD8
	[return: Dynamic(new bool[]
	{
		false,
		true
	})]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	protected UniTask<dynamic> NewBattleSkillItem(AActor rootActor, int inputIndex, bool useExplore)
	{
		TrapDefenseSkillPanelBase.<NewBattleSkillItem>d__15 <NewBattleSkillItem>d__;
		<NewBattleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
		<NewBattleSkillItem>d__.<>4__this = this;
		<NewBattleSkillItem>d__.rootActor = rootActor;
		<NewBattleSkillItem>d__.inputIndex = inputIndex;
		<NewBattleSkillItem>d__.useExplore = useExplore;
		<NewBattleSkillItem>d__.<>1__state = -1;
		<NewBattleSkillItem>d__.<>t__builder.Start<TrapDefenseSkillPanelBase.<NewBattleSkillItem>d__15>(ref <NewBattleSkillItem>d__);
		return <NewBattleSkillItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600E302 RID: 58114
	protected abstract string[] GetActionNameList();

	// Token: 0x0600E303 RID: 58115 RVA: 0x00355B33 File Offset: 0x00353D33
	protected virtual void OnChildStart()
	{
	}

	// Token: 0x040068DB RID: 26843
	protected readonly List<BattleSkillItem> BattleSkillItemList = new List<BattleSkillItem>();

	// Token: 0x040068DC RID: 26844
	protected Dictionary<int, TrapDefenseBattleSkillData> DataMap = new Dictionary<int, TrapDefenseBattleSkillData>();
}
