using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x020028E6 RID: 10470
public class RedDotCiacconaEndingReward : RedDotBase
{
	// Token: 0x0601A74F RID: 108367 RVA: 0x0082C5A8 File Offset: 0x0082A7A8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A750 RID: 108368 RVA: 0x0082C5C6 File Offset: 0x0082A7C6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A751 RID: 108369 RVA: 0x0082C5E4 File Offset: 0x0082A7E4
	protected override bool OnCheck(int uId = 0)
	{
		return CiacconaGalModel.Instance.HasAnyEndingReward();
	}
}
