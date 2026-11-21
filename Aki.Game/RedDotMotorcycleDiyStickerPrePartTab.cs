using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200294F RID: 10575
public class RedDotMotorcycleDiyStickerPrePartTab : RedDotBase
{
	// Token: 0x0601A938 RID: 108856 RVA: 0x00830170 File Offset: 0x0082E370
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A939 RID: 108857 RVA: 0x00830173 File Offset: 0x0082E373
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A93A RID: 108858 RVA: 0x00830191 File Offset: 0x0082E391
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A93B RID: 108859 RVA: 0x008301AF File Offset: 0x0082E3AF
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Sticker, new int?(uId));
	}
}
