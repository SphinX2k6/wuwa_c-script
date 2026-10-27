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

// Token: 0x02001CBE RID: 7358
public class KurotatoSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600DE8E RID: 56974 RVA: 0x0034152A File Offset: 0x0033F72A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600DE8F RID: 56975 RVA: 0x00341550 File Offset: 0x0033F750
	public override UniTask InitializeAsync()
	{
		KurotatoSkillPanel.<InitializeAsync>d__3 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<KurotatoSkillPanel.<InitializeAsync>d__3>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE90 RID: 56976 RVA: 0x00341593 File Offset: 0x0033F793
	protected override void OnStart()
	{
		KurotatoModel.Instance.BattleData.InitBattleSkillData();
		this.RefreshDodgeSkillItem();
	}

	// Token: 0x0600DE91 RID: 56977 RVA: 0x003415AA File Offset: 0x0033F7AA
	private void RefreshDodgeSkillItem()
	{
		this.DodgeSkillItem.Refresh(KurotatoModel.Instance.BattleData.GetBattleSkillData("闪避"));
	}

	// Token: 0x0600DE92 RID: 56978 RVA: 0x003415CB File Offset: 0x0033F7CB
	protected override void OnHideBattleChildViewPanel()
	{
		this.DodgeSkillItem.TryReleaseButton();
	}

	// Token: 0x0600DE93 RID: 56979 RVA: 0x003415D8 File Offset: 0x0033F7D8
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (!this.Visible)
		{
			return;
		}
		this.DodgeSkillItem.Tick(delta);
	}

	// Token: 0x0600DE94 RID: 56980 RVA: 0x003415F0 File Offset: 0x0033F7F0
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600DE95 RID: 56981 RVA: 0x00341650 File Offset: 0x0033F850
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
	}

	// Token: 0x0600DE96 RID: 56982 RVA: 0x003416AE File Offset: 0x0033F8AE
	private void OnChangedTimeScale()
	{
		this.DodgeSkillItem.RefreshTimeDilation();
	}

	// Token: 0x0600DE97 RID: 56983 RVA: 0x003416BB File Offset: 0x0033F8BB
	private void OnPauseGame(int flag)
	{
		this.DodgeSkillItem.PauseGame(flag);
	}

	// Token: 0x0600DE98 RID: 56984 RVA: 0x003416C9 File Offset: 0x0033F8C9
	private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
	{
		if (buttonType == ESkillButtonType.闪避)
		{
			this.DodgeSkillItem.RefreshSkillCoolDown();
		}
	}

	// Token: 0x0400663A RID: 26170
	[Nullable(2)]
	protected BattleSkillItem DodgeSkillItem;

	// Token: 0x020082AD RID: 33453
	private static class EComponentDefine
	{
		// Token: 0x0402AA1C RID: 174620
		public const int Dodge = 0;
	}
}
