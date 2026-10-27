using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02003402 RID: 13314
public class RedDotFunctionViewQuestBtn : RedDotBase
{
	// Token: 0x0601CCF1 RID: 118001 RVA: 0x0080AF3F File Offset: 0x0080913F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCF2 RID: 118002 RVA: 0x0080AF5D File Offset: 0x0080915D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCF3 RID: 118003 RVA: 0x0080AF7C File Offset: 0x0080917C
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

	// Token: 0x0601CCF4 RID: 118004 RVA: 0x0080AFF4 File Offset: 0x008091F4
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
