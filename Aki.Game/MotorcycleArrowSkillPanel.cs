using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CD2 RID: 7378
public class MotorcycleArrowSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600DF69 RID: 57193 RVA: 0x003454D1 File Offset: 0x003436D1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600DF6A RID: 57194 RVA: 0x003454F4 File Offset: 0x003436F4
	public override UniTask InitializeAsync()
	{
		MotorcycleArrowSkillPanel.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<MotorcycleArrowSkillPanel.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF6B RID: 57195 RVA: 0x00345537 File Offset: 0x00343737
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.ActiveSkillItem.RefreshSkillCoolDownOnShow();
	}

	// Token: 0x0600DF6C RID: 57196 RVA: 0x00345544 File Offset: 0x00343744
	protected override void OnHideBattleChildViewPanel()
	{
		this.ActiveSkillItem.TryReleaseButton();
	}

	// Token: 0x0600DF6D RID: 57197 RVA: 0x00345551 File Offset: 0x00343751
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (!this.Visible)
		{
			return;
		}
		this.ActiveSkillItem.Tick(delta);
	}

	// Token: 0x0600DF6E RID: 57198 RVA: 0x00345568 File Offset: 0x00343768
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
		EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
		EventSystem.Instance.Add(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
	}

	// Token: 0x0600DF6F RID: 57199 RVA: 0x00345600 File Offset: 0x00343800
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
		EventSystem.Instance.Remove(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
		EventSystem.Instance.Remove(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
	}

	// Token: 0x0600DF70 RID: 57200 RVA: 0x00345698 File Offset: 0x00343898
	private void OnCountDownEnd()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		MotorcycleArrowBattleSkillData skillData = this.SkillData;
		MotorcycleArrowSubModel motorcycleArrowSubModel2 = motorcycleArrowSubModel;
		skillData.SetVisible(motorcycleArrowSubModel2.LevelConfig != null && motorcycleArrowSubModel2.LevelConfig.GetValueOrDefault().SkillEnable == 1);
		this.ActiveSkillItem.RefreshVisible();
	}

	// Token: 0x0600DF71 RID: 57201 RVA: 0x003456F0 File Offset: 0x003438F0
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

	// Token: 0x0600DF72 RID: 57202 RVA: 0x00345788 File Offset: 0x00343988
	private void OnKscPlayerCreate()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		AKSC_Entity kscPlayerEntity = motorcycleArrowSubModel.KscPlayerEntity;
		this.SkillData = motorcycleArrowSubModel.GetMotorcycleArrowBattleSkillData();
		this.SkillData.InitAttrData(kscPlayerEntity);
		this.RefreshActiveSkillItem();
	}

	// Token: 0x0600DF73 RID: 57203 RVA: 0x003457CC File Offset: 0x003439CC
	private void RefreshActiveSkillItem()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		this.ActiveSkillItem.Refresh(motorcycleArrowSubModel.GetMotorcycleArrowBattleSkillData());
	}

	// Token: 0x0600DF74 RID: 57204 RVA: 0x003457FA File Offset: 0x003439FA
	private void OnChangedTimeScale()
	{
		this.ActiveSkillItem.RefreshTimeDilation();
	}

	// Token: 0x0600DF75 RID: 57205 RVA: 0x00345807 File Offset: 0x00343A07
	private void OnPauseGame(int flag)
	{
		this.ActiveSkillItem.PauseGame(flag);
	}

	// Token: 0x0600DF76 RID: 57206 RVA: 0x00345815 File Offset: 0x00343A15
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

	// Token: 0x040066C6 RID: 26310
	[Nullable(2)]
	protected BattleSkillItem ActiveSkillItem;

	// Token: 0x040066C7 RID: 26311
	[Nullable(2)]
	protected MotorcycleArrowBattleSkillData SkillData;

	// Token: 0x020082D5 RID: 33493
	private static class EComponentDefine
	{
		// Token: 0x0402AAFC RID: 174844
		public const int Skill = 0;
	}
}
