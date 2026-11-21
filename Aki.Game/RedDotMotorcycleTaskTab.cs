using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002943 RID: 10563
public class RedDotMotorcycleTaskTab : RedDotBase
{
	// Token: 0x0601A8F9 RID: 108793 RVA: 0x0082F9B1 File Offset: 0x0082DBB1
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A8FA RID: 108794 RVA: 0x0082F9B4 File Offset: 0x0082DBB4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8FB RID: 108795 RVA: 0x0082F9EE File Offset: 0x0082DBEE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8FC RID: 108796 RVA: 0x0082FA28 File Offset: 0x0082DC28
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotCanGetAnyTaskReward();
	}
}
