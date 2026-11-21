using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C60 RID: 3168
public class ChatTeamTipsContent : UiPanelBase
{
	// Token: 0x06008460 RID: 33888 RVA: 0x002885DC File Offset: 0x002867DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008461 RID: 33889 RVA: 0x002886A8 File Offset: 0x002868A8
	[NullableContext(1)]
	public void Refresh(ChatContentData data)
	{
		this.ChatContentData = data;
		ChatChannelNoticeType noticeType = this.ChatContentData.NoticeType;
		if (noticeType != ChatChannelNoticeType.EnterTeam)
		{
			if (noticeType == ChatChannelNoticeType.ExitTeam)
			{
				UUIItem item = base.GetItem(1);
				UUIItem item2 = base.GetItem(3);
				UUIText text = base.GetText(2);
				string senderPlayerName = this.ChatContentData.SenderPlayerName;
				item.SetUIActive(true);
				item2.SetUIActive(false);
				LguiUtil.Instance.SetLocalText(text, "PlayerLeaveTeam", new <>z__ReadOnlySingleElementList<object>(senderPlayerName));
			}
		}
		else
		{
			UUIItem item3 = base.GetItem(1);
			UUIItem item4 = base.GetItem(3);
			UUIText text2 = base.GetText(4);
			string senderPlayerName2 = this.ChatContentData.SenderPlayerName;
			item3.SetUIActive(false);
			item4.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text2, "PlayerEnterTeam", new <>z__ReadOnlySingleElementList<object>(senderPlayerName2));
		}
		this.RefreshTimeText();
	}

	// Token: 0x06008462 RID: 33890 RVA: 0x00288770 File Offset: 0x00286970
	private void RefreshTimeText()
	{
		UUIText text = base.GetText(0);
		double timeStamp = this.ChatContentData.TimeStamp;
		double lastTimeStamp = this.ChatContentData.LastTimeStamp;
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (timeStamp - lastTimeStamp < (double)ChatModel.Instance.ShowTimeDifferent && lastTimeStamp != 0.0)
		{
			text.SetUIActive(false);
			return;
		}
		DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp(timeStamp);
		DateTime dataFromTimeStamp2 = TimeUtil.Instance.GetDataFromTimeStamp(serverTime);
		if (dataFromTimeStamp.Day == dataFromTimeStamp2.Day)
		{
			LguiUtil.Instance.SetLocalText(text, "HourText", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Hour.ToString("D2"),
				dataFromTimeStamp.Minute.ToString("D2")
			}));
			text.SetUIActive(true);
			return;
		}
		if (dataFromTimeStamp.Day != dataFromTimeStamp2.Day && dataFromTimeStamp.Year == dataFromTimeStamp2.Year)
		{
			LguiUtil.Instance.SetLocalText(text, "DayText", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Month.ToString("D2"),
				dataFromTimeStamp.Day.ToString("D2"),
				dataFromTimeStamp.Hour.ToString("D2"),
				dataFromTimeStamp.Minute.ToString("D2")
			}));
			text.SetUIActive(true);
			return;
		}
		if (dataFromTimeStamp.Year != dataFromTimeStamp2.Year)
		{
			LguiUtil.Instance.SetLocalText(text, "YearText", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Year.ToString(),
				dataFromTimeStamp.Month.ToString("D2"),
				dataFromTimeStamp.Day.ToString("D2"),
				dataFromTimeStamp.Hour.ToString("D2"),
				dataFromTimeStamp.Minute.ToString("D2")
			}));
			text.SetUIActive(true);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x040050CE RID: 20686
	[Nullable(2)]
	private ChatContentData ChatContentData;

	// Token: 0x02006F3E RID: 28478
	private class EChildType
	{
		// Token: 0x040245AE RID: 148910
		public const int TimeText = 0;

		// Token: 0x040245AF RID: 148911
		public const int LeaveItem = 1;

		// Token: 0x040245B0 RID: 148912
		public const int LeaveText = 2;

		// Token: 0x040245B1 RID: 148913
		public const int EnterItem = 3;

		// Token: 0x040245B2 RID: 148914
		public const int EnterText = 4;
	}
}
