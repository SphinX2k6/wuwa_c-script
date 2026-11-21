using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029BC RID: 10684
public class RedDotTrapDefenseTalentTree : RedDotBase
{
	// Token: 0x0601AB34 RID: 109364 RVA: 0x00834500 File Offset: 0x00832700
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefense);
	}

	// Token: 0x0601AB35 RID: 109365 RVA: 0x0083450C File Offset: 0x0083270C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseTalentTree, new Action(base.EventCheck));
	}

	// Token: 0x0601AB36 RID: 109366 RVA: 0x0083452A File Offset: 0x0083272A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseTalentTree, new Action(base.EventCheck));
	}

	// Token: 0x0601AB37 RID: 109367 RVA: 0x00834548 File Offset: 0x00832748
	protected override bool OnCheck(int uId = 0)
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		return instance != null && instance.TalentTreeData.HasAnyNodeCanUnlockAndAfford();
	}
}
