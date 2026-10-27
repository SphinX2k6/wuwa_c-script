using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033DA RID: 13274
public class RedDotMotorcycleDiyFramePreTab : RedDotBase
{
	// Token: 0x0601CC31 RID: 117809 RVA: 0x00809A07 File Offset: 0x00807C07
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC32 RID: 117810 RVA: 0x00809A0A File Offset: 0x00807C0A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC33 RID: 117811 RVA: 0x00809A28 File Offset: 0x00807C28
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC34 RID: 117812 RVA: 0x00809A48 File Offset: 0x00807C48
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Frame, null);
	}
}
