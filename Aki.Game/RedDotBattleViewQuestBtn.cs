using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02003401 RID: 13313
public class RedDotBattleViewQuestBtn : RedDotBase
{
	// Token: 0x0601CCEC RID: 117996 RVA: 0x0080ADFD File Offset: 0x00808FFD
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCED RID: 117997 RVA: 0x0080AE1B File Offset: 0x0080901B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCEE RID: 117998 RVA: 0x0080AE3C File Offset: 0x0080903C
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

	// Token: 0x0601CCEF RID: 117999 RVA: 0x0080AF34 File Offset: 0x00809134
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
