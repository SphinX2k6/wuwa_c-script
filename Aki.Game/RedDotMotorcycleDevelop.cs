using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200293F RID: 10559
public class RedDotMotorcycleDevelop : RedDotBase
{
	// Token: 0x0601A8E4 RID: 108772 RVA: 0x0082F602 File Offset: 0x0082D802
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601A8E5 RID: 108773 RVA: 0x0082F60C File Offset: 0x0082D80C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8E6 RID: 108774 RVA: 0x0082F6E0 File Offset: 0x0082D8E0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8E7 RID: 108775 RVA: 0x0082F7B4 File Offset: 0x0082D9B4
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.MotorDevelop) && (MotorcycleDevelopModel.Instance.RedDotHasLevelUpReward() || MotorcycleDevelopModel.Instance.RedDotHasAnyNewTechTree() || MotorcycleDevelopModel.Instance.RedDotHasUpgradableTechNode(null) || MotorcycleDevelopModel.Instance.RedDotCanGetAnyTaskReward() || MotorcycleDiyModel.Instance.RedDotForDiyTab());
	}

	// Token: 0x0601A8E8 RID: 108776 RVA: 0x0082F819 File Offset: 0x0082DA19
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
