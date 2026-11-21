using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002940 RID: 10560
public class RedDotMotorcycleDiyTab : RedDotBase
{
	// Token: 0x0601A8EA RID: 108778 RVA: 0x0082F829 File Offset: 0x0082DA29
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A8EB RID: 108779 RVA: 0x0082F82C File Offset: 0x0082DA2C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8EC RID: 108780 RVA: 0x0082F890 File Offset: 0x0082DA90
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8ED RID: 108781 RVA: 0x0082F8F1 File Offset: 0x0082DAF1
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotForDiyTab();
	}
}
