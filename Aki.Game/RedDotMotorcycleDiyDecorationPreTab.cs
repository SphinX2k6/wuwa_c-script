using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200294A RID: 10570
public class RedDotMotorcycleDiyDecorationPreTab : RedDotBase
{
	// Token: 0x0601A91F RID: 108831 RVA: 0x0082FEDD File Offset: 0x0082E0DD
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A920 RID: 108832 RVA: 0x0082FEE0 File Offset: 0x0082E0E0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A921 RID: 108833 RVA: 0x0082FEFE File Offset: 0x0082E0FE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A922 RID: 108834 RVA: 0x0082FF1C File Offset: 0x0082E11C
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Decoration);
	}
}
