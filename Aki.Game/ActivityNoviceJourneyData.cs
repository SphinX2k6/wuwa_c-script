using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000889 RID: 2185
[NullableContext(1)]
[Nullable(0)]
public class ActivityNoviceJourneyData : ActivityBaseData
{
	// Token: 0x060062E1 RID: 25313 RVA: 0x001F81AE File Offset: 0x001F63AE
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckHasCanReceive();
	}

	// Token: 0x060062E2 RID: 25314 RVA: 0x001F81B8 File Offset: 0x001F63B8
	protected override void PhraseEx(ActivityData data)
	{
		NewBieCourseActivity newBieCourseActivity = data.NewBieCourseActivity;
		this.SetReceiveData(newBieCourseActivity.HadTakeReward);
	}

	// Token: 0x060062E3 RID: 25315 RVA: 0x001F81D8 File Offset: 0x001F63D8
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

	// Token: 0x060062E4 RID: 25316 RVA: 0x001F821C File Offset: 0x001F641C
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

	// Token: 0x060062E5 RID: 25317 RVA: 0x001F8260 File Offset: 0x001F6460
	public void SetReceiveData(IReadOnlyList<int> receivedList)
	{
		foreach (int item in receivedList)
		{
			this.ReceivedSet.Add(item);
		}
	}

	// Token: 0x060062E6 RID: 25318 RVA: 0x001F82B0 File Offset: 0x001F64B0
	public void AddReceivedData(int level)
	{
		this.ReceivedSet.Add(level);
		EventSystem.Instance.Emit<int>(EEventName.NoticeJourneyReceive, level);
	}

	// Token: 0x060062E7 RID: 25319 RVA: 0x001F82D0 File Offset: 0x001F64D0
	public bool CheckRewardReceived(int level)
	{
		return this.ReceivedSet.Contains(level);
	}

	// Token: 0x060062E8 RID: 25320 RVA: 0x001F82E0 File Offset: 0x001F64E0
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

	// Token: 0x04004001 RID: 16385
	private readonly HashSet<int> ReceivedSet = new HashSet<int>();
}
