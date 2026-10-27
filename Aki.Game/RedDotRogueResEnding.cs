using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003411 RID: 13329
public class RedDotRogueResEnding : RedDotBase
{
	// Token: 0x0601CD38 RID: 118072 RVA: 0x0080B896 File Offset: 0x00809A96
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD39 RID: 118073 RVA: 0x0080B8B4 File Offset: 0x00809AB4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD3A RID: 118074 RVA: 0x0080B8D2 File Offset: 0x00809AD2
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckEndingAwardRedDot(uId);
	}
}
