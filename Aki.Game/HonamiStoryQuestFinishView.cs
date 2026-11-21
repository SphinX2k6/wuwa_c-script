using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013A8 RID: 5032
public class HonamiStoryQuestFinishView : UiViewBase
{
	// Token: 0x0600C7A6 RID: 51110 RVA: 0x003B6FE4 File Offset: 0x003B51E4
	[NullableContext(1)]
	public HonamiStoryQuestFinishView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7A7 RID: 51111 RVA: 0x003B6FF0 File Offset: 0x003B51F0
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

	// Token: 0x0600C7A8 RID: 51112 RVA: 0x003B7059 File Offset: 0x003B5259
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

	// Token: 0x0600C7A9 RID: 51113 RVA: 0x003B708E File Offset: 0x003B528E
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600C7AA RID: 51114 RVA: 0x003B7098 File Offset: 0x003B5298
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

	// Token: 0x040071A7 RID: 29095
	[Nullable(2)]
	private HonamiStorySubQuestData QuestData;

	// Token: 0x02007662 RID: 30306
	private enum EHonamiStoryQuestComponents
	{
		// Token: 0x040266EF RID: 157423
		TextTitle,
		// Token: 0x040266F0 RID: 157424
		TextQuestName
	}
}
