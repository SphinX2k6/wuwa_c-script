using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002948 RID: 10568
public class RedDotMotorcycleDiyDecorationPartTab : RedDotBase
{
	// Token: 0x0601A915 RID: 108821 RVA: 0x0082FDE2 File Offset: 0x0082DFE2
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A916 RID: 108822 RVA: 0x0082FDE5 File Offset: 0x0082DFE5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A917 RID: 108823 RVA: 0x0082FE1F File Offset: 0x0082E01F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A918 RID: 108824 RVA: 0x0082FE59 File Offset: 0x0082E059
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Decoration, new int?(uId)) && MotorcycleDiyModel.Instance.RedDotHasNewDecorationByPart(uId);
	}
}
