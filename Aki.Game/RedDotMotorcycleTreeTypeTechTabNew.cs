using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D5 RID: 13269
public class RedDotMotorcycleTreeTypeTechTabNew : RedDotBase
{
	// Token: 0x0601CC17 RID: 117783 RVA: 0x00809737 File Offset: 0x00807937
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC18 RID: 117784 RVA: 0x0080973C File Offset: 0x0080793C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Add(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC19 RID: 117785 RVA: 0x008097A0 File Offset: 0x008079A0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC1A RID: 117786 RVA: 0x00809801 File Offset: 0x00807A01
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotHasNewTechTree(uId);
	}

	// Token: 0x0601CC1B RID: 117787 RVA: 0x0080980E File Offset: 0x00807A0E
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
