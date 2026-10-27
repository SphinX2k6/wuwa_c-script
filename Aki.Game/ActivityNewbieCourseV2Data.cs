using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02001398 RID: 5016
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewbieCourseV2Data : ActivityBaseData
{
	// Token: 0x06008CAB RID: 36011 RVA: 0x001E2950 File Offset: 0x001E0B50
	protected override void OnInit(ActivityData data)
	{
		this.UpdateProtocolBeginOpenTime(data);
	}

	// Token: 0x06008CAC RID: 36012 RVA: 0x001E295C File Offset: 0x001E0B5C
	protected override void PhraseEx(ActivityData data)
	{
		this.UpdateProtocolBeginOpenTime(data);
		this.ReceivedSet.Clear();
		NewbieCourseV2ActivityPb newbieCourseV2ActivityPb = data.NewbieCourseV2ActivityPb;
		int[] array;
		if (newbieCourseV2ActivityPb == null)
		{
			array = null;
		}
		else
		{
			RepeatedField<int> hadTakeReward = newbieCourseV2ActivityPb.HadTakeReward;
			array = ((hadTakeReward != null) ? hadTakeReward.ToArray<int>() : null);
		}
		this.SetReceiveData(array ?? Array.Empty<int>());
	}

	// Token: 0x06008CAD RID: 36013 RVA: 0x001E29AC File Offset: 0x001E0BAC
	private void UpdateProtocolBeginOpenTime(ActivityData data)
	{
		NewbieCourseV2ActivityPb newbieCourseV2ActivityPb = data.NewbieCourseV2ActivityPb;
		if (newbieCourseV2ActivityPb != null)
		{
			this.ProtocolBeginOpenTime = MathUtils.Instance.LongToBigInt(newbieCourseV2ActivityPb.BeginOpenTime);
			return;
		}
		if (data.BeginOpenTime != 0L)
		{
			this.ProtocolBeginOpenTime = MathUtils.Instance.LongToBigInt(data.BeginOpenTime);
			return;
		}
		this.ProtocolBeginOpenTime = 0L;
	}

	// Token: 0x06008CAE RID: 36014 RVA: 0x001E2A01 File Offset: 0x001E0C01
	public override long GetProtocolBeginOpenTime()
	{
		return this.ProtocolBeginOpenTime;
	}

	// Token: 0x06008CAF RID: 36015 RVA: 0x001E2A09 File Offset: 0x001E0C09
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckHasCanReceive();
	}

	// Token: 0x06008CB0 RID: 36016 RVA: 0x001E2A14 File Offset: 0x001E0C14
	protected override bool GetExDataFinishShowState()
	{
		IReadOnlyList<NewbieCourseV2> configList = ActivityNewbieCourseV2Config.Instance.GetConfigList(base.Id);
		if (configList.Count <= 0)
		{
			return false;
		}
		foreach (NewbieCourseV2 newbieCourseV in configList)
		{
			if (this.GetRewardState(newbieCourseV.TargetLevel) != ENewbieCourseV2ItemState.HasReceived)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008CB1 RID: 36017 RVA: 0x001E2A88 File Offset: 0x001E0C88
	public void SetReceiveData(int[] receivedList)
	{
		this.ReceivedSet.Clear();
		foreach (int item in receivedList)
		{
			this.ReceivedSet.Add(item);
		}
	}

	// Token: 0x06008CB2 RID: 36018 RVA: 0x001E2AC1 File Offset: 0x001E0CC1
	public void AddReceivedData(int level)
	{
		this.ReceivedSet.Add(level);
	}

	// Token: 0x06008CB3 RID: 36019 RVA: 0x001E2AD0 File Offset: 0x001E0CD0
	public ENewbieCourseV2ItemState GetRewardState(int targetLevel)
	{
		int? playerLevel = PlayerInfoModel.Instance.GetPlayerLevel();
		if (playerLevel.GetValueOrDefault() < targetLevel & playerLevel != null)
		{
			return ENewbieCourseV2ItemState.Unaccomplished;
		}
		if (this.ReceivedSet.Contains(targetLevel))
		{
			return ENewbieCourseV2ItemState.HasReceived;
		}
		return ENewbieCourseV2ItemState.CanReceive;
	}

	// Token: 0x06008CB4 RID: 36020 RVA: 0x001E2B14 File Offset: 0x001E0D14
	private bool CheckHasCanReceive()
	{
		foreach (NewbieCourseV2 newbieCourseV in ActivityNewbieCourseV2Config.Instance.GetConfigList(base.Id))
		{
			if (this.GetRewardState(newbieCourseV.TargetLevel) == ENewbieCourseV2ItemState.CanReceive)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04003E65 RID: 15973
	private readonly HashSet<int> ReceivedSet = new HashSet<int>();

	// Token: 0x04003E66 RID: 15974
	private long ProtocolBeginOpenTime;
}
