using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002944 RID: 10564
public class RedDotMotorcycleTechTreeTab : RedDotBase
{
	// Token: 0x0601A8FE RID: 108798 RVA: 0x0082FA3C File Offset: 0x0082DC3C
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A8FF RID: 108799 RVA: 0x0082FA40 File Offset: 0x0082DC40
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A900 RID: 108800 RVA: 0x0082FAC0 File Offset: 0x0082DCC0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A901 RID: 108801 RVA: 0x0082FB40 File Offset: 0x0082DD40
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = MotorcycleDevelopModel.Instance.RedDotHasAnyNewTechTree();
		bool flag2 = MotorcycleDevelopModel.Instance.RedDotHasUpgradableTechNode(null);
		return flag || flag2;
	}

	// Token: 0x0601A902 RID: 108802 RVA: 0x0082FB6D File Offset: 0x0082DD6D
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
