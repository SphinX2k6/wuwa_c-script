using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200294E RID: 10574
public class RedDotMotorcycleDiyStickerPartTab : RedDotBase
{
	// Token: 0x0601A933 RID: 108851 RVA: 0x008300CF File Offset: 0x0082E2CF
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A934 RID: 108852 RVA: 0x008300D2 File Offset: 0x0082E2D2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A935 RID: 108853 RVA: 0x0083010C File Offset: 0x0082E30C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A936 RID: 108854 RVA: 0x00830146 File Offset: 0x0082E346
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Sticker, new int?(uId)) && MotorcycleDiyModel.Instance.RedDotHasNewStickerByPart(uId);
	}
}
