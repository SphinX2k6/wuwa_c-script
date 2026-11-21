using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;

// Token: 0x02002989 RID: 10633
public class RedDotRogueResShop : RedDotBase
{
	// Token: 0x0601AA4B RID: 109131 RVA: 0x0083210B File Offset: 0x0083030B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA4C RID: 109132 RVA: 0x00832129 File Offset: 0x00830329
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PermanentRogueSeasonRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA4D RID: 109133 RVA: 0x00832147 File Offset: 0x00830347
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityPermanentRogueModel.Instance.CheckShopRedDot(uId);
	}
}
