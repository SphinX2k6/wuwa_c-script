using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001194 RID: 4500
public class MotorcycleArrowSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600B386 RID: 45958 RVA: 0x00350EF9 File Offset: 0x0034F0F9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B387 RID: 45959 RVA: 0x00350F1C File Offset: 0x0034F11C
	public override UniTask InitializeAsync()
	{
		MotorcycleArrowSkillPanel.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<MotorcycleArrowSkillPanel.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B388 RID: 45960 RVA: 0x00350F5F File Offset: 0x0034F15F
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.ActiveSkillItem.RefreshSkillCoolDownOnShow();
	}

	// Token: 0x0600B389 RID: 45961 RVA: 0x00350F6C File Offset: 0x0034F16C
	protected override void OnHideBattleChildViewPanel()
	{
		this.ActiveSkillItem.TryReleaseButton();
	}

	// Token: 0x0600B38A RID: 45962 RVA: 0x00350F79 File Offset: 0x0034F179
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (!this.Visible)
		{
			return;
		}
		this.ActiveSkillItem.Tick(delta);
	}

	// Token: 0x0600B38B RID: 45963 RVA: 0x00350F90 File Offset: 0x0034F190
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
		EventSystem.Instance.Add(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
	}

	// Token: 0x0600B38C RID: 45964 RVA: 0x00351028 File Offset: 0x0034F228
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
		EventSystem.Instance.Remove(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
	}

	// Token: 0x0600B38D RID: 45965 RVA: 0x003510C0 File Offset: 0x0034F2C0
	private void OnCountDownEnd()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		MotorcycleArrowBattleSkillData skillData = this.SkillData;
		MotorcycleArrowSubModel motorcycleArrowSubModel2 = motorcycleArrowSubModel;
		skillData.SetVisible(motorcycleArrowSubModel2.LevelConfig != null && motorcycleArrowSubModel2.LevelConfig.GetValueOrDefault().SkillEnable == 1);
		this.ActiveSkillItem.RefreshVisible();
	}

	// Token: 0x0600B38E RID: 45966 RVA: 0x00351118 File Offset: 0x0034F318
	private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
	{
		MotorcycleArrowBattleSkillData skillData = this.SkillData;
		ESkillButtonType? eskillButtonType = (skillData != null) ? new ESkillButtonType?(skillData.GetButtonType()) : null;
		if (!(buttonType == eskillButtonType.GetValueOrDefault() & eskillButtonType != null))
		{
			return;
		}
		BattleSkillItem activeSkillItem = this.ActiveSkillItem;
		bool flag = activeSkillItem != null && activeSkillItem.GetSkillButtonInteractive();
		BattleSkillItem activeSkillItem2 = this.ActiveSkillItem;
		if (activeSkillItem2 != null)
		{
			activeSkillItem2.RefreshAttribute(true);
		}
		BattleSkillItem activeSkillItem3 = this.ActiveSkillItem;
		bool flag2 = activeSkillItem3 != null && activeSkillItem3.GetSkillButtonInteractive();
		if (flag != flag2 && flag2)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "OnMotorFightChargeFull");
		}
	}

	// Token: 0x0600B38F RID: 45967 RVA: 0x003511B0 File Offset: 0x0034F3B0
	private void OnKscPlayerCreate()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		AKSC_Entity kscPlayerEntity = motorcycleArrowSubModel.KscPlayerEntity;
		this.SkillData = motorcycleArrowSubModel.GetMotorcycleArrowBattleSkillData();
		this.SkillData.InitAttrData(kscPlayerEntity);
		this.RefreshActiveSkillItem();
	}

	// Token: 0x0600B390 RID: 45968 RVA: 0x003511F4 File Offset: 0x0034F3F4
	private void RefreshActiveSkillItem()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		this.ActiveSkillItem.Refresh(motorcycleArrowSubModel.GetMotorcycleArrowBattleSkillData());
	}

	// Token: 0x0600B391 RID: 45969 RVA: 0x00351222 File Offset: 0x0034F422
	private void OnChangedTimeScale()
	{
		this.ActiveSkillItem.RefreshTimeDilation();
	}

	// Token: 0x0600B392 RID: 45970 RVA: 0x0035122F File Offset: 0x0034F42F
	private void OnPauseGame(int flag)
	{
		this.ActiveSkillItem.PauseGame(flag);
	}

	// Token: 0x0600B393 RID: 45971 RVA: 0x0035123D File Offset: 0x0034F43D
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public UUIItem[] GetSkillGuideItem()
	{
		BattleSkillItem activeSkillItem = this.ActiveSkillItem;
		if (activeSkillItem == null)
		{
			return null;
		}
		return activeSkillItem.GetGuideItem();
	}

	// Token: 0x040067A5 RID: 26533
	[Nullable(2)]
	protected BattleSkillItem ActiveSkillItem;

	// Token: 0x040067A6 RID: 26534
	[Nullable(2)]
	protected MotorcycleArrowBattleSkillData SkillData;

	// Token: 0x0200745E RID: 29790
	private static class EComponentDefine
	{
		// Token: 0x04025E24 RID: 155172
		public const int Skill = 0;
	}
}
