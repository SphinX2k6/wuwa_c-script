using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033CD RID: 13261
public class RedDotMotorcycleDevelop : RedDotBase
{
	// Token: 0x0601CBEC RID: 117740 RVA: 0x0080903E File Offset: 0x0080723E
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601CBED RID: 117741 RVA: 0x00809048 File Offset: 0x00807248
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

	// Token: 0x0601CBEE RID: 117742 RVA: 0x0080911C File Offset: 0x0080731C
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

	// Token: 0x0601CBEF RID: 117743 RVA: 0x008091F0 File Offset: 0x008073F0
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.MotorDevelop) && (MotorcycleDevelopModel.Instance.RedDotHasLevelUpReward() || MotorcycleDevelopModel.Instance.RedDotHasAnyNewTechTree() || MotorcycleDevelopModel.Instance.RedDotHasUpgradableTechNode(null) || MotorcycleDevelopModel.Instance.RedDotCanGetAnyTaskReward() || MotorcycleDiyModel.Instance.RedDotForDiyTab());
	}

	// Token: 0x0601CBF0 RID: 117744 RVA: 0x00809255 File Offset: 0x00807455
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
