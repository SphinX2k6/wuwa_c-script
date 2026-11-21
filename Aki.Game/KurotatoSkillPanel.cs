using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001180 RID: 4480
public class KurotatoSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600B2AB RID: 45739 RVA: 0x0034CF52 File Offset: 0x0034B152
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B2AC RID: 45740 RVA: 0x0034CF78 File Offset: 0x0034B178
	public override UniTask InitializeAsync()
	{
		KurotatoSkillPanel.<InitializeAsync>d__3 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<KurotatoSkillPanel.<InitializeAsync>d__3>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2AD RID: 45741 RVA: 0x0034CFBB File Offset: 0x0034B1BB
	protected override void OnStart()
	{
		KurotatoModel.Instance.BattleData.InitBattleSkillData();
		this.RefreshDodgeSkillItem();
	}

	// Token: 0x0600B2AE RID: 45742 RVA: 0x0034CFD2 File Offset: 0x0034B1D2
	private void RefreshDodgeSkillItem()
	{
		this.DodgeSkillItem.Refresh(KurotatoModel.Instance.BattleData.GetBattleSkillData("闪避"));
	}

	// Token: 0x0600B2AF RID: 45743 RVA: 0x0034CFF3 File Offset: 0x0034B1F3
	protected override void OnHideBattleChildViewPanel()
	{
		this.DodgeSkillItem.TryReleaseButton();
	}

	// Token: 0x0600B2B0 RID: 45744 RVA: 0x0034D000 File Offset: 0x0034B200
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (!this.Visible)
		{
			return;
		}
		this.DodgeSkillItem.Tick(delta);
	}

	// Token: 0x0600B2B1 RID: 45745 RVA: 0x0034D018 File Offset: 0x0034B218
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600B2B2 RID: 45746 RVA: 0x0034D078 File Offset: 0x0034B278
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600B2B3 RID: 45747 RVA: 0x0034D0D6 File Offset: 0x0034B2D6
	private void OnChangedTimeScale()
	{
		this.DodgeSkillItem.RefreshTimeDilation();
	}

	// Token: 0x0600B2B4 RID: 45748 RVA: 0x0034D0E3 File Offset: 0x0034B2E3
	private void OnPauseGame(int flag)
	{
		this.DodgeSkillItem.PauseGame(flag);
	}

	// Token: 0x0600B2B5 RID: 45749 RVA: 0x0034D0F1 File Offset: 0x0034B2F1
	private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
	{
		if (buttonType == ESkillButtonType.闪避)
		{
			this.DodgeSkillItem.RefreshSkillCoolDown();
		}
	}

	// Token: 0x04006719 RID: 26393
	[Nullable(2)]
	protected BattleSkillItem DodgeSkillItem;

	// Token: 0x02007436 RID: 29750
	private static class EComponentDefine
	{
		// Token: 0x04025D44 RID: 154948
		public const int Dodge = 0;
	}
}
