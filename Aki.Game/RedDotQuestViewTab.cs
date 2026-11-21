using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x02002976 RID: 10614
public class RedDotQuestViewTab : RedDotBase
{
	// Token: 0x0601A9F2 RID: 109042 RVA: 0x00831628 File Offset: 0x0082F828
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9F3 RID: 109043 RVA: 0x00831646 File Offset: 0x0082F846
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9F4 RID: 109044 RVA: 0x00831664 File Offset: 0x0082F864
	protected unsafe override bool OnCheck(int uId = 0)
	{
		foreach (QuestType questType in QuestNewConfig.Instance.GetQuesTypesByMainType(uId))
		{
			List<global::Quest> questsByType = QuestNewModel.Instance.GetQuestsByType(questType.Id);
			if (questsByType != null)
			{
				foreach (global::Quest quest in questsByType)
				{
					if (quest.CanShowInUiPanel() && QuestNewModel.Instance.CheckQuestRedDotDataState(quest.Id).GetValueOrDefault())
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Quest;
						ELogAuthor author = ELogAuthor.YSQ;
						string message = "RedDotQuestViewTab：任务红点显示";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mainTypeId", uId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("questId", quest.Id);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0601A9F5 RID: 109045 RVA: 0x008317A0 File Offset: 0x0082F9A0
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9F6 RID: 109046 RVA: 0x008317A3 File Offset: 0x0082F9A3
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
