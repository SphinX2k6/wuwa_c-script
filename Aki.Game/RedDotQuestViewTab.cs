using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x02003404 RID: 13316
public class RedDotQuestViewTab : RedDotBase
{
	// Token: 0x0601CCFA RID: 118010 RVA: 0x0080B064 File Offset: 0x00809264
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCFB RID: 118011 RVA: 0x0080B082 File Offset: 0x00809282
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCFC RID: 118012 RVA: 0x0080B0A0 File Offset: 0x008092A0
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

	// Token: 0x0601CCFD RID: 118013 RVA: 0x0080B1DC File Offset: 0x008093DC
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCFE RID: 118014 RVA: 0x0080B1DF File Offset: 0x008093DF
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}
}
