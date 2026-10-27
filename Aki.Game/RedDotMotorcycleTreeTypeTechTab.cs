using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D4 RID: 13268
public class RedDotMotorcycleTreeTypeTechTab : RedDotBase
{
	// Token: 0x0601CC11 RID: 117777 RVA: 0x0080964A File Offset: 0x0080784A
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC12 RID: 117778 RVA: 0x00809650 File Offset: 0x00807850
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Add(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC13 RID: 117779 RVA: 0x008096B4 File Offset: 0x008078B4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnMotorDevelopTechTreeUpdate));
		EventSystem.Instance.Remove(EEventName.MotorDevelopTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC14 RID: 117780 RVA: 0x00809715 File Offset: 0x00807915
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotHasUpgradableTechNode(new int?(uId));
	}

	// Token: 0x0601CC15 RID: 117781 RVA: 0x00809727 File Offset: 0x00807927
	private void OnMotorDevelopTechTreeUpdate(bool isUpdateNode)
	{
		base.EventCheck();
	}
}
