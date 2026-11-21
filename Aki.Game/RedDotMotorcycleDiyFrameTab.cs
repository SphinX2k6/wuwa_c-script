using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200294D RID: 10573
public class RedDotMotorcycleDiyFrameTab : RedDotBase
{
	// Token: 0x0601A92E RID: 108846 RVA: 0x00830035 File Offset: 0x0082E235
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A92F RID: 108847 RVA: 0x00830038 File Offset: 0x0082E238
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A930 RID: 108848 RVA: 0x00830072 File Offset: 0x0082E272
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A931 RID: 108849 RVA: 0x008300AC File Offset: 0x0082E2AC
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Frame) && MotorcycleDiyModel.Instance.RedDotHasNewFrame();
	}
}
