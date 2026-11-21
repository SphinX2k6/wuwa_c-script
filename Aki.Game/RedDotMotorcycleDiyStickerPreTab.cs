using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002950 RID: 10576
public class RedDotMotorcycleDiyStickerPreTab : RedDotBase
{
	// Token: 0x0601A93D RID: 108861 RVA: 0x008301CA File Offset: 0x0082E3CA
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A93E RID: 108862 RVA: 0x008301CD File Offset: 0x0082E3CD
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A93F RID: 108863 RVA: 0x008301EB File Offset: 0x0082E3EB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A940 RID: 108864 RVA: 0x00830209 File Offset: 0x0082E409
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Sticker);
	}
}
