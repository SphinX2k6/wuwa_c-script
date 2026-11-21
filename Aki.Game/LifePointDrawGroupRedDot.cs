using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200074F RID: 1871
public class LifePointDrawGroupRedDot : RedDotBase
{
	// Token: 0x06005600 RID: 22016 RVA: 0x001C3A09 File Offset: 0x001C1C09
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshLifePointDrawGroupRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06005601 RID: 22017 RVA: 0x001C3A27 File Offset: 0x001C1C27
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshLifePointDrawGroupRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06005602 RID: 22018 RVA: 0x001C3A45 File Offset: 0x001C1C45
	protected override bool OnCheck(int groupId)
	{
		return LifePointDrawModel.Instance.GetGroupRedDotState(groupId);
	}
}
