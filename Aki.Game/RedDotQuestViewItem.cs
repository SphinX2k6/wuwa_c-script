using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002975 RID: 10613
public class RedDotQuestViewItem : RedDotBase
{
	// Token: 0x0601A9EE RID: 109038 RVA: 0x008315C3 File Offset: 0x0082F7C3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9EF RID: 109039 RVA: 0x008315E1 File Offset: 0x0082F7E1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9F0 RID: 109040 RVA: 0x00831600 File Offset: 0x0082F800
	protected override bool OnCheck(int uId = 0)
	{
		return QuestNewModel.Instance.CheckQuestRedDotDataState(uId).GetValueOrDefault();
	}
}
