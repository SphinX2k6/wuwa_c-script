using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002949 RID: 10569
public class RedDotMotorcycleDiyDecorationPrePartTab : RedDotBase
{
	// Token: 0x0601A91A RID: 108826 RVA: 0x0082FE83 File Offset: 0x0082E083
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A91B RID: 108827 RVA: 0x0082FE86 File Offset: 0x0082E086
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A91C RID: 108828 RVA: 0x0082FEA4 File Offset: 0x0082E0A4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A91D RID: 108829 RVA: 0x0082FEC2 File Offset: 0x0082E0C2
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Decoration, new int?(uId));
	}
}
