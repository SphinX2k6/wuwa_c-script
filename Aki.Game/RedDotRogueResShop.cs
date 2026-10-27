using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02003417 RID: 13335
public class RedDotRogueResShop : RedDotBase
{
	// Token: 0x0601CD53 RID: 118099 RVA: 0x0080BB47 File Offset: 0x00809D47
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD54 RID: 118100 RVA: 0x0080BB65 File Offset: 0x00809D65
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD55 RID: 118101 RVA: 0x0080BB83 File Offset: 0x00809D83
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckShopRedDot(uId);
	}
}
