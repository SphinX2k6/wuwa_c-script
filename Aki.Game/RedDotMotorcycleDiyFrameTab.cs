using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033DB RID: 13275
public class RedDotMotorcycleDiyFrameTab : RedDotBase
{
	// Token: 0x0601CC36 RID: 117814 RVA: 0x00809A71 File Offset: 0x00807C71
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC37 RID: 117815 RVA: 0x00809A74 File Offset: 0x00807C74
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC38 RID: 117816 RVA: 0x00809AAE File Offset: 0x00807CAE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC39 RID: 117817 RVA: 0x00809AE8 File Offset: 0x00807CE8
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Frame) && MotorcycleDiyModel.Instance.RedDotHasNewFrame();
	}
}
