using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020013D5 RID: 5077
[NullableContext(1)]
[Nullable(0)]
public class ActivityNoviceJourneyData : ActivityBaseData
{
	// Token: 0x06008F4C RID: 36684 RVA: 0x001EF692 File Offset: 0x001ED892
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckHasCanReceive();
	}

	// Token: 0x06008F4D RID: 36685 RVA: 0x001EF69C File Offset: 0x001ED89C
	protected override void PhraseEx(ActivityData data)
	{
		NewBieCourseActivity newBieCourseActivity = data.NewBieCourseActivity;
		this.SetReceiveData(newBieCourseActivity.HadTakeReward.ToArray<int>());
	}

	// Token: 0x06008F4E RID: 36686 RVA: 0x001EF6C4 File Offset: 0x001ED8C4
	protected override bool GetExDataFinishShowState()
	{
		foreach (NewbieCourse newbieCourse in ActivityNoviceJourneyConfig.Instance.GetNoticeJourneyConfigList())
		{
			if (this.GetRewardStateByLevel(newbieCourse.Id) != NoviceJourneyDefine.EItemState.HasReceived)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008F4F RID: 36687 RVA: 0x001EF708 File Offset: 0x001ED908
	private bool CheckHasCanReceive()
	{
		foreach (NewbieCourse newbieCourse in ActivityNoviceJourneyConfig.Instance.GetNoticeJourneyConfigList())
		{
			if (this.GetRewardStateByLevel(newbieCourse.Id) == NoviceJourneyDefine.EItemState.CanReceive)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008F50 RID: 36688 RVA: 0x001EF74C File Offset: 0x001ED94C
	public void SetReceiveData(int[] receivedList)
	{
		foreach (int item in receivedList)
		{
			this.ReceivedSet.Add(item);
		}
	}

	// Token: 0x06008F51 RID: 36689 RVA: 0x001EF77A File Offset: 0x001ED97A
	public void AddReceivedData(int level)
	{
		this.ReceivedSet.Add(level);
		EventSystem.Instance.Emit<int>(EEventName.NoticeJourneyReceive, level);
	}

	// Token: 0x06008F52 RID: 36690 RVA: 0x001EF79A File Offset: 0x001ED99A
	public bool CheckRewardReceived(int level)
	{
		return this.ReceivedSet.Contains(level);
	}

	// Token: 0x06008F53 RID: 36691 RVA: 0x001EF7A8 File Offset: 0x001ED9A8
	public NoviceJourneyDefine.EItemState GetRewardStateByLevel(int level)
	{
		int? playerLevel = PlayerInfoModel.Instance.GetPlayerLevel();
		if (playerLevel.GetValueOrDefault() < level & playerLevel != null)
		{
			return NoviceJourneyDefine.EItemState.Unaccomplished;
		}
		if (!this.CheckRewardReceived(level))
		{
			return NoviceJourneyDefine.EItemState.CanReceive;
		}
		return NoviceJourneyDefine.EItemState.HasReceived;
	}

	// Token: 0x04003F69 RID: 16233
	private readonly HashSet<int> ReceivedSet = new HashSet<int>();
}
