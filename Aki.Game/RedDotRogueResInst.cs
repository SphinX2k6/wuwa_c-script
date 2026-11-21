using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02002988 RID: 10632
public class RedDotRogueResInst : RedDotBase
{
	// Token: 0x0601AA47 RID: 109127 RVA: 0x008320BA File Offset: 0x008302BA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA48 RID: 109128 RVA: 0x008320D8 File Offset: 0x008302D8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA49 RID: 109129 RVA: 0x008320F6 File Offset: 0x008302F6
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckDungeonRedDot(uId);
	}
}
