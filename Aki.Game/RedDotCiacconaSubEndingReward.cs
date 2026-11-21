using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x020028E7 RID: 10471
public class RedDotCiacconaSubEndingReward : RedDotBase
{
	// Token: 0x0601A753 RID: 108371 RVA: 0x0082C5F8 File Offset: 0x0082A7F8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A754 RID: 108372 RVA: 0x0082C616 File Offset: 0x0082A816
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A755 RID: 108373 RVA: 0x0082C634 File Offset: 0x0082A834
	protected override bool OnCheck(int uId = 0)
	{
		return CiacconaGalModel.Instance.HasAnySubEndingReward();
	}
}
