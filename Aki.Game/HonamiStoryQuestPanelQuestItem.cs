using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001EFF RID: 7935
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryQuestPanelQuestItem : GridProxyAbstract<HonamiStoryQuestDataBase>
{
	// Token: 0x0600F45A RID: 62554 RVA: 0x003AF108 File Offset: 0x003AD308
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F45B RID: 62555 RVA: 0x003AF194 File Offset: 0x003AD394
	[NullableContext(1)]
	public override void Refresh(HonamiStoryQuestDataBase data, bool isSelected, int gridIndex)
	{
		int taskType = (int)data.TaskType;
		UUIText text = base.GetText(0);
		if (taskType == 1)
		{
			if (text != null)
			{
				text.SetRichText(true);
			}
			BehaviorTreeViewShowData treeShowData = data.GetTreeShowData();
			BehaviorTreeStepTextInfo behaviorTreeStepTextInfo = (treeShowData != null) ? treeShowData.MainStepInfo : null;
			string text2 = "";
			if (behaviorTreeStepTextInfo != null)
			{
				text2 = PublicUtil.Instance.GetConfigTextByKey(behaviorTreeStepTextInfo.TidTitle);
			}
			if (text != null)
			{
				text.SetText(StringUtils.Format("<color=#b3dffa>{0}</color>", new string[]
				{
					text2
				}), true);
			}
		}
		else
		{
			HonamiStoryAreaTask? config = (data as HonamiStorySubQuestData).Config;
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(data.GetNameKey(), null);
			if (config.Value.TaskType != 1)
			{
				if (text != null)
				{
					text.SetRichText(false);
				}
				if (text != null)
				{
					text.SetText(localTextNew, true);
				}
			}
			else
			{
				if (text != null)
				{
					text.SetRichText(true);
				}
				if (text != null)
				{
					text.SetText(StringUtils.Format("<color=#b3dffa>{0}</color>", new string[]
					{
						localTextNew
					}), true);
				}
			}
		}
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(1).SetUIActive(true);
	}

	// Token: 0x02008500 RID: 34048
	private enum EHonamiStoryQuestItemComponent
	{
		// Token: 0x0402B489 RID: 177289
		QuestNameText,
		// Token: 0x0402B48A RID: 177290
		UnFinishSprite,
		// Token: 0x0402B48B RID: 177291
		FinishSprite
	}
}
