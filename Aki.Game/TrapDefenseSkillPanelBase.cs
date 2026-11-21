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

// Token: 0x020011FF RID: 4607
[NullableContext(1)]
[Nullable(0)]
public abstract class TrapDefenseSkillPanelBase : BattleChildViewPanel
{
	// Token: 0x0600B711 RID: 46865 RVA: 0x00361111 File Offset: 0x0035F311
	protected override void OnStart()
	{
		this.RefreshAllBattleSkillItems();
		this.OnChildStart();
	}

	// Token: 0x0600B712 RID: 46866 RVA: 0x00361120 File Offset: 0x0035F320
	protected override void OnAfterShow()
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.RefreshEnable(true);
		}
	}

	// Token: 0x0600B713 RID: 46867 RVA: 0x00361174 File Offset: 0x0035F374
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.RefreshSkillCoolDownOnShow();
		}
	}

	// Token: 0x0600B714 RID: 46868 RVA: 0x003611C4 File Offset: 0x0035F3C4
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

	// Token: 0x0600B715 RID: 46869 RVA: 0x00361220 File Offset: 0x0035F420
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

	// Token: 0x0600B716 RID: 46870 RVA: 0x0036127C File Offset: 0x0035F47C
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600B717 RID: 46871 RVA: 0x003612F8 File Offset: 0x0035F4F8
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600B718 RID: 46872 RVA: 0x00361374 File Offset: 0x0035F574
	private void OnChangedTimeScale()
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.RefreshTimeDilation();
		}
	}

	// Token: 0x0600B719 RID: 46873 RVA: 0x003613C4 File Offset: 0x0035F5C4
	private void OnPauseGame(int flag)
	{
		foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
		{
			battleSkillItem.PauseGame(flag);
		}
	}

	// Token: 0x0600B71A RID: 46874 RVA: 0x00361418 File Offset: 0x0035F618
	private void OnSkillButtonSkillIdRefresh(ESkillButtonType buttonType)
	{
		this.RefreshSkillItemByButtonType(buttonType);
	}

	// Token: 0x0600B71B RID: 46875 RVA: 0x00361421 File Offset: 0x0035F621
	private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
	{
		this.RefreshSkillItemByButtonType(buttonType);
	}

	// Token: 0x0600B71C RID: 46876 RVA: 0x0036142C File Offset: 0x0035F62C
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

	// Token: 0x0600B71D RID: 46877 RVA: 0x00361484 File Offset: 0x0035F684
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

	// Token: 0x0600B71E RID: 46878 RVA: 0x00361508 File Offset: 0x0035F708
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

	// Token: 0x0600B71F RID: 46879
	protected abstract string[] GetActionNameList();

	// Token: 0x0600B720 RID: 46880 RVA: 0x00361563 File Offset: 0x0035F763
	protected virtual void OnChildStart()
	{
	}

	// Token: 0x040069BA RID: 27066
	protected readonly List<BattleSkillItem> BattleSkillItemList = new List<BattleSkillItem>();

	// Token: 0x040069BB RID: 27067
	protected Dictionary<int, TrapDefenseBattleSkillData> DataMap = new Dictionary<int, TrapDefenseBattleSkillData>();
}
