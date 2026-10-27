using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D2 RID: 13266
public class RedDotMotorcycleTechTreeTab : RedDotBase
{
	// Token: 0x0601CC06 RID: 117766 RVA: 0x00809478 File Offset: 0x00807678
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC07 RID: 117767 RVA: 0x0080947C File Offset: 0x0080767C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC08 RID: 117768 RVA: 0x008094FC File Offset: 0x008076FC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC09 RID: 117769 RVA: 0x0080957C File Offset: 0x0080777C
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = MotorcycleDevelopModel.Instance.RedDotHasAnyNewTechTree();
		bool flag2 = MotorcycleDevelopModel.Instance.RedDotHasUpgradableTechNode(null);
		return flag || flag2;
	}

	// Token: 0x0601CC0A RID: 117770 RVA: 0x008095A9 File Offset: 0x008077A9
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
