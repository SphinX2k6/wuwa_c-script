using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033CF RID: 13263
public class RedDotMotorcycleLevelTab : RedDotBase
{
	// Token: 0x0601CBF7 RID: 117751 RVA: 0x00809341 File Offset: 0x00807541
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CBF8 RID: 117752 RVA: 0x00809344 File Offset: 0x00807544
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBF9 RID: 117753 RVA: 0x00809362 File Offset: 0x00807562
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBFA RID: 117754 RVA: 0x00809380 File Offset: 0x00807580
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDevelopModel.Instance.RedDotHasLevelUpReward();
	}
}
