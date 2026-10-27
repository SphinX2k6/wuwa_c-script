using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EE6 RID: 7910
public class HonamiStoryQuestFinishView : UiViewBase
{
	// Token: 0x0600F387 RID: 62343 RVA: 0x003AB4E8 File Offset: 0x003A96E8
	[NullableContext(1)]
	public HonamiStoryQuestFinishView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F388 RID: 62344 RVA: 0x003AB4F4 File Offset: 0x003A96F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F389 RID: 62345 RVA: 0x003AB55D File Offset: 0x003A975D
	protected override void OnStart()
	{
		this.QuestData = (HonamiStorySubQuestData)this.OpenParam;
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
		{
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				base.CloseMe(null);
			}, null, null);
		}, false);
	}

	// Token: 0x0600F38A RID: 62346 RVA: 0x003AB592 File Offset: 0x003A9792
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600F38B RID: 62347 RVA: 0x003AB59C File Offset: 0x003A979C
	private void RefreshView()
	{
		HonamiStorySubQuestData questData = this.QuestData;
		if (questData == null)
		{
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(questData.GetNameKey(), null);
		UUIText text = base.GetText(1);
		string newText;
		if (questData.Config.Value.TaskType != 1)
		{
			if (text != null)
			{
				text.SetRichText(false);
			}
			newText = localTextNew;
		}
		else
		{
			if (text != null)
			{
				text.SetRichText(true);
			}
			newText = StringUtils.Format("<color=#b3dffa>{0}</color>", new string[]
			{
				localTextNew
			});
		}
		if (text != null)
		{
			text.SetText(newText, true);
		}
	}

	// Token: 0x040070C6 RID: 28870
	[Nullable(2)]
	private HonamiStorySubQuestData QuestData;

	// Token: 0x020084DD RID: 34013
	private enum EHonamiStoryQuestComponents
	{
		// Token: 0x0402B3CB RID: 177099
		TextTitle,
		// Token: 0x0402B3CC RID: 177100
		TextQuestName
	}
}
