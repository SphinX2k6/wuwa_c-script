using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003418 RID: 13336
public class RedDotRogueResSkillTree : RedDotBase
{
	// Token: 0x0601CD57 RID: 118103 RVA: 0x0080BB98 File Offset: 0x00809D98
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSkillCurrencyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD58 RID: 118104 RVA: 0x0080BBD2 File Offset: 0x00809DD2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSkillCurrencyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD59 RID: 118105 RVA: 0x0080BC0C File Offset: 0x00809E0C
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckSkillTreeRedDot(uId);
	}
}
