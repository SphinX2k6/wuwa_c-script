using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002945 RID: 10565
public class RedDotMotorcycleTreeTypeTaskTab : RedDotBase
{
	// Token: 0x0601A904 RID: 108804 RVA: 0x0082FB7D File Offset: 0x0082DD7D
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A905 RID: 108805 RVA: 0x0082FB80 File Offset: 0x0082DD80
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A906 RID: 108806 RVA: 0x0082FBBA File Offset: 0x0082DDBA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A907 RID: 108807 RVA: 0x0082FBF4 File Offset: 0x0082DDF4
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotCanGetTaskReward(new int?(uId));
	}
}
