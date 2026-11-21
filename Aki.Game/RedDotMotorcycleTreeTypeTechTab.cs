using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002946 RID: 10566
public class RedDotMotorcycleTreeTypeTechTab : RedDotBase
{
	// Token: 0x0601A909 RID: 108809 RVA: 0x0082FC0E File Offset: 0x0082DE0E
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A90A RID: 108810 RVA: 0x0082FC14 File Offset: 0x0082DE14
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A90B RID: 108811 RVA: 0x0082FC78 File Offset: 0x0082DE78
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A90C RID: 108812 RVA: 0x0082FCD9 File Offset: 0x0082DED9
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotHasUpgradableTechNode(new int?(uId));
	}

	// Token: 0x0601A90D RID: 108813 RVA: 0x0082FCEB File Offset: 0x0082DEEB
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
