using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033DE RID: 13278
public class RedDotMotorcycleDiyStickerPreTab : RedDotBase
{
	// Token: 0x0601CC45 RID: 117829 RVA: 0x00809C06 File Offset: 0x00807E06
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC46 RID: 117830 RVA: 0x00809C09 File Offset: 0x00807E09
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC47 RID: 117831 RVA: 0x00809C27 File Offset: 0x00807E27
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC48 RID: 117832 RVA: 0x00809C45 File Offset: 0x00807E45
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Sticker);
	}
}
