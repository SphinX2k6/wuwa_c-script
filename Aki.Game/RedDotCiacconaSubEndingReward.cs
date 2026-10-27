using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x02003375 RID: 13173
public class RedDotCiacconaSubEndingReward : RedDotBase
{
	// Token: 0x0601CA5B RID: 117339 RVA: 0x00806034 File Offset: 0x00804234
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA5C RID: 117340 RVA: 0x00806052 File Offset: 0x00804252
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA5D RID: 117341 RVA: 0x00806070 File Offset: 0x00804270
	protected override bool OnCheck(int uId = 0)
	{
		return CiacconaGalModel.Instance.HasAnySubEndingReward();
	}
}
