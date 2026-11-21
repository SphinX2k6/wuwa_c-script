using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02002974 RID: 10612
public class RedDotFunctionViewQuestBtn : RedDotBase
{
	// Token: 0x0601A9E9 RID: 109033 RVA: 0x00831503 File Offset: 0x0082F703
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9EA RID: 109034 RVA: 0x00831521 File Offset: 0x0082F721
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9EB RID: 109035 RVA: 0x00831540 File Offset: 0x0082F740
	protected override bool OnCheck(int uId = 0)
	{
		foreach (KeyValuePair<int, bool> keyValuePair in QuestNewModel.Instance.GetAllRedDotData())
		{
			int key = keyValuePair.Key;
			Quest quest = QuestNewModel.Instance.GetQuest(key);
			if (quest != null && quest.CanShowInUiPanel())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A9EC RID: 109036 RVA: 0x008315B8 File Offset: 0x0082F7B8
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
