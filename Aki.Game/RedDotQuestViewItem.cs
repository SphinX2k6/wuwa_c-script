using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003403 RID: 13315
public class RedDotQuestViewItem : RedDotBase
{
	// Token: 0x0601CCF6 RID: 118006 RVA: 0x0080AFFF File Offset: 0x008091FF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCF7 RID: 118007 RVA: 0x0080B01D File Offset: 0x0080921D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCF8 RID: 118008 RVA: 0x0080B03C File Offset: 0x0080923C
	protected override bool OnCheck(int uId = 0)
	{
		return QuestNewModel.Instance.CheckQuestRedDotDataState(uId).GetValueOrDefault();
	}
}
