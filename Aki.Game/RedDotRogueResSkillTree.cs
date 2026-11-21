using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x0200298A RID: 10634
public class RedDotRogueResSkillTree : RedDotBase
{
	// Token: 0x0601AA4F RID: 109135 RVA: 0x0083215C File Offset: 0x0083035C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSkillCurrencyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA50 RID: 109136 RVA: 0x00832196 File Offset: 0x00830396
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSkillCurrencyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA51 RID: 109137 RVA: 0x008321D0 File Offset: 0x008303D0
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckSkillTreeRedDot(uId);
	}
}
