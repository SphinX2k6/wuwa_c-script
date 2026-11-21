using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02002973 RID: 10611
public class RedDotBattleViewQuestBtn : RedDotBase
{
	// Token: 0x0601A9E4 RID: 109028 RVA: 0x008313C1 File Offset: 0x0082F5C1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9E5 RID: 109029 RVA: 0x008313DF File Offset: 0x0082F5DF
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9E6 RID: 109030 RVA: 0x00831400 File Offset: 0x0082F600
	protected override bool OnCheck(int uId = 0)
	{
		Dictionary<int, bool> allRedDotData = QuestNewModel.Instance.GetAllRedDotData();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Quest;
		ELogAuthor author = ELogAuthor.YSQ;
		string message = "开始检测主界面任务红点";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("红点数据量", (allRedDotData != null) ? new int?(allRedDotData.Count) : null);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (KeyValuePair<int, bool> keyValuePair in allRedDotData)
		{
			int key = keyValuePair.Key;
			Quest quest = QuestNewModel.Instance.GetQuest(key);
			if (quest != null && quest.CanShowInUiPanel())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Quest;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "主界面任务红点";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("红点任务", quest.Id);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A9E7 RID: 109031 RVA: 0x008314F8 File Offset: 0x0082F6F8
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
