using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002947 RID: 10567
public class RedDotMotorcycleTreeTypeTechTabNew : RedDotBase
{
	// Token: 0x0601A90F RID: 108815 RVA: 0x0082FCFB File Offset: 0x0082DEFB
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A910 RID: 108816 RVA: 0x0082FD00 File Offset: 0x0082DF00
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Add(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A911 RID: 108817 RVA: 0x0082FD64 File Offset: 0x0082DF64
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTreeTypeRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A912 RID: 108818 RVA: 0x0082FDC5 File Offset: 0x0082DFC5
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotHasNewTechTree(uId);
	}

	// Token: 0x0601A913 RID: 108819 RVA: 0x0082FDD2 File Offset: 0x0082DFD2
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
