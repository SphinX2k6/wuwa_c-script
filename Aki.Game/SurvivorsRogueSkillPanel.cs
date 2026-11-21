using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011E4 RID: 4580
public class SurvivorsRogueSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600B5E7 RID: 46567 RVA: 0x0035C258 File Offset: 0x0035A458
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600B5E8 RID: 46568 RVA: 0x0035C294 File Offset: 0x0035A494
	public override UniTask InitializeAsync()
	{
		SurvivorsRogueSkillPanel.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<SurvivorsRogueSkillPanel.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B5E9 RID: 46569 RVA: 0x0035C2D7 File Offset: 0x0035A4D7
	protected override void OnStart()
	{
		SurvivorsRogueModel.Instance.BattleData.InitBattleSkillData();
		this.RefreshAllBattleSkillItems();
	}

	// Token: 0x0600B5EA RID: 46570 RVA: 0x0035C2EE File Offset: 0x0035A4EE
	private void RefreshAllBattleSkillItems()
	{
		this.RefreshActiveSkillItem();
		this.RefreshDodgeSkillItem();
	}

	// Token: 0x0600B5EB RID: 46571 RVA: 0x0035C2FC File Offset: 0x0035A4FC
	private void RefreshActiveSkillItem()
	{
		this.ActiveSkillItem.Refresh(SurvivorsRogueModel.Instance.BattleData.GetBattleSkillData("技能1"));
	}

	// Token: 0x0600B5EC RID: 46572 RVA: 0x0035C31D File Offset: 0x0035A51D
	private void RefreshDodgeSkillItem()
	{
		this.DodgeSkillItem.Refresh(SurvivorsRogueModel.Instance.BattleData.GetBattleSkillData("闪避"));
	}

	// Token: 0x0600B5ED RID: 46573 RVA: 0x0035C33E File Offset: 0x0035A53E
	protected override void OnShowBattleChildViewPanel(bool first)
	{
		this.ActiveSkillItem.RefreshSkillCoolDownOnShow();
	}

	// Token: 0x0600B5EE RID: 46574 RVA: 0x0035C34B File Offset: 0x0035A54B
	protected override void OnHideBattleChildViewPanel()
	{
		this.ActiveSkillItem.TryReleaseButton();
		this.DodgeSkillItem.TryReleaseButton();
	}

	// Token: 0x0600B5EF RID: 46575 RVA: 0x0035C363 File Offset: 0x0035A563
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (!this.Visible)
		{
			return;
		}
		this.ActiveSkillItem.Tick(delta);
		this.DodgeSkillItem.Tick(delta);
	}

	// Token: 0x0600B5F0 RID: 46576 RVA: 0x0035C388 File Offset: 0x0035A588
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600B5F1 RID: 46577 RVA: 0x0035C3E8 File Offset: 0x0035A5E8
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600B5F2 RID: 46578 RVA: 0x0035C446 File Offset: 0x0035A646
	private void OnChangedTimeScale()
	{
		this.ActiveSkillItem.RefreshTimeDilation();
		this.DodgeSkillItem.RefreshTimeDilation();
	}

	// Token: 0x0600B5F3 RID: 46579 RVA: 0x0035C45E File Offset: 0x0035A65E
	private void OnPauseGame(int flag)
	{
		this.ActiveSkillItem.PauseGame(flag);
		this.DodgeSkillItem.PauseGame(flag);
	}

	// Token: 0x0600B5F4 RID: 46580 RVA: 0x0035C478 File Offset: 0x0035A678
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

	// Token: 0x04006953 RID: 26963
	[Nullable(2)]
	protected BattleSkillItem ActiveSkillItem;

	// Token: 0x04006954 RID: 26964
	[Nullable(2)]
	protected BattleSkillItem DodgeSkillItem;

	// Token: 0x020074A5 RID: 29861
	private static class EComponentDefine
	{
		// Token: 0x04025F58 RID: 155480
		public const int Skill = 0;

		// Token: 0x04025F59 RID: 155481
		public const int Dodge = 1;
	}
}
