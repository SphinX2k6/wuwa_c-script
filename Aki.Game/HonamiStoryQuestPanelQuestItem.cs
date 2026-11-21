using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013C1 RID: 5057
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryQuestPanelQuestItem : GridProxyAbstract<HonamiStoryQuestDataBase>
{
	// Token: 0x0600C879 RID: 51321 RVA: 0x003BABFC File Offset: 0x003B8DFC
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

	// Token: 0x0600C87A RID: 51322 RVA: 0x003BAC88 File Offset: 0x003B8E88
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

	// Token: 0x02007685 RID: 30341
	private enum EHonamiStoryQuestItemComponent
	{
		// Token: 0x040267AD RID: 157613
		QuestNameText,
		// Token: 0x040267AE RID: 157614
		UnFinishSprite,
		// Token: 0x040267AF RID: 157615
		FinishSprite
	}
}
