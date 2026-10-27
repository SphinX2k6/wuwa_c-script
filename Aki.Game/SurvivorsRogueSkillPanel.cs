using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D22 RID: 7458
public class SurvivorsRogueSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600E1CA RID: 57802 RVA: 0x00350828 File Offset: 0x0034EA28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600E1CB RID: 57803 RVA: 0x00350864 File Offset: 0x0034EA64
	public override UniTask InitializeAsync()
	{
		SurvivorsRogueSkillPanel.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<SurvivorsRogueSkillPanel.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E1CC RID: 57804 RVA: 0x003508A7 File Offset: 0x0034EAA7
	protected override void OnStart()
	{
		SurvivorsRogueModel.Instance.BattleData.InitBattleSkillData();
		this.RefreshAllBattleSkillItems();
	}

	// Token: 0x0600E1CD RID: 57805 RVA: 0x003508BE File Offset: 0x0034EABE
	private void RefreshAllBattleSkillItems()
	{
		this.RefreshActiveSkillItem();
		this.RefreshDodgeSkillItem();
	}

	// Token: 0x0600E1CE RID: 57806 RVA: 0x003508CC File Offset: 0x0034EACC
	private void RefreshActiveSkillItem()
	{
		this.ActiveSkillItem.Refresh(SurvivorsRogueModel.Instance.BattleData.GetBattleSkillData("技能1"));
	}

	// Token: 0x0600E1CF RID: 57807 RVA: 0x003508ED File Offset: 0x0034EAED
	private void RefreshDodgeSkillItem()
	{
		this.DodgeSkillItem.Refresh(SurvivorsRogueModel.Instance.BattleData.GetBattleSkillData("闪避"));
	}

	// Token: 0x0600E1D0 RID: 57808 RVA: 0x0035090E File Offset: 0x0034EB0E
	protected override void OnShowBattleChildViewPanel(bool first)
	{
		this.ActiveSkillItem.RefreshSkillCoolDownOnShow();
	}

	// Token: 0x0600E1D1 RID: 57809 RVA: 0x0035091B File Offset: 0x0034EB1B
	protected override void OnHideBattleChildViewPanel()
	{
		this.ActiveSkillItem.TryReleaseButton();
		this.DodgeSkillItem.TryReleaseButton();
	}

	// Token: 0x0600E1D2 RID: 57810 RVA: 0x00350933 File Offset: 0x0034EB33
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (!this.Visible)
		{
			return;
		}
		this.ActiveSkillItem.Tick(delta);
		this.DodgeSkillItem.Tick(delta);
	}

	// Token: 0x0600E1D3 RID: 57811 RVA: 0x00350958 File Offset: 0x0034EB58
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600E1D4 RID: 57812 RVA: 0x003509B8 File Offset: 0x0034EBB8
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600E1D5 RID: 57813 RVA: 0x00350A16 File Offset: 0x0034EC16
	private void OnChangedTimeScale()
	{
		this.ActiveSkillItem.RefreshTimeDilation();
		this.DodgeSkillItem.RefreshTimeDilation();
	}

	// Token: 0x0600E1D6 RID: 57814 RVA: 0x00350A2E File Offset: 0x0034EC2E
	private void OnPauseGame(int flag)
	{
		this.ActiveSkillItem.PauseGame(flag);
		this.DodgeSkillItem.PauseGame(flag);
	}

	// Token: 0x0600E1D7 RID: 57815 RVA: 0x00350A48 File Offset: 0x0034EC48
	private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
	{
		if (buttonType == ESkillButtonType.技能1)
		{
			this.ActiveSkillItem.RefreshSkillCoolDown();
			return;
		}
		if (buttonType == ESkillButtonType.闪避)
		{
			this.DodgeSkillItem.RefreshSkillCoolDown();
		}
	}

	// Token: 0x04006874 RID: 26740
	[Nullable(2)]
	protected BattleSkillItem ActiveSkillItem;

	// Token: 0x04006875 RID: 26741
	[Nullable(2)]
	protected BattleSkillItem DodgeSkillItem;

	// Token: 0x0200831C RID: 33564
	private static class EComponentDefine
	{
		// Token: 0x0402AC30 RID: 175152
		public const int Skill = 0;

		// Token: 0x0402AC31 RID: 175153
		public const int Dodge = 1;
	}
}
