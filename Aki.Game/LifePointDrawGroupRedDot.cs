using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200129B RID: 4763
public class LifePointDrawGroupRedDot : RedDotBase
{
	// Token: 0x06008269 RID: 33385 RVA: 0x001BAD39 File Offset: 0x001B8F39
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshLifePointDrawGroupRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600826A RID: 33386 RVA: 0x001BAD57 File Offset: 0x001B8F57
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshLifePointDrawGroupRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600826B RID: 33387 RVA: 0x001BAD75 File Offset: 0x001B8F75
	protected override bool OnCheck(int groupId)
	{
		return LifePointDrawModel.Instance.GetGroupRedDotState(groupId);
	}
}
