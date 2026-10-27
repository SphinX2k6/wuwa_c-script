using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003416 RID: 13334
public class RedDotRogueResInst : RedDotBase
{
	// Token: 0x0601CD4F RID: 118095 RVA: 0x0080BAF6 File Offset: 0x00809CF6
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD50 RID: 118096 RVA: 0x0080BB14 File Offset: 0x00809D14
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD51 RID: 118097 RVA: 0x0080BB32 File Offset: 0x00809D32
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckDungeonRedDot(uId);
	}
}
