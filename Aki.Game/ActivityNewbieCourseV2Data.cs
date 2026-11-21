using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x0200084C RID: 2124
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewbieCourseV2Data : ActivityBaseData
{
	// Token: 0x06006044 RID: 24644 RVA: 0x001EB6E7 File Offset: 0x001E98E7
	protected override void OnInit(ActivityData data)
	{
		this.UpdateProtocolBeginOpenTime(data);
	}

	// Token: 0x06006045 RID: 24645 RVA: 0x001EB6F0 File Offset: 0x001E98F0
	protected override void PhraseEx(ActivityData data)
	{
		this.UpdateProtocolBeginOpenTime(data);
		this.ReceivedSet.Clear();
		NewbieCourseV2ActivityPb newbieCourseV2ActivityPb = data.NewbieCourseV2ActivityPb;
		RepeatedField<int> repeatedField = (newbieCourseV2ActivityPb != null) ? newbieCourseV2ActivityPb.HadTakeReward : null;
		this.SetReceiveData((repeatedField == null) ? new List<int>() : new List<int>(repeatedField));
	}

	// Token: 0x06006046 RID: 24646 RVA: 0x001EB738 File Offset: 0x001E9938
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

	// Token: 0x06006047 RID: 24647 RVA: 0x001EB78D File Offset: 0x001E998D
	public override long GetProtocolBeginOpenTime()
	{
		return this.ProtocolBeginOpenTime;
	}

	// Token: 0x06006048 RID: 24648 RVA: 0x001EB795 File Offset: 0x001E9995
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckHasCanReceive();
	}

	// Token: 0x06006049 RID: 24649 RVA: 0x001EB7A0 File Offset: 0x001E99A0
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

	// Token: 0x0600604A RID: 24650 RVA: 0x001EB814 File Offset: 0x001E9A14
	public void SetReceiveData(IReadOnlyList<int> receivedList)
	{
		this.ReceivedSet.Clear();
		foreach (int item in receivedList)
		{
			this.ReceivedSet.Add(item);
		}
	}

	// Token: 0x0600604B RID: 24651 RVA: 0x001EB870 File Offset: 0x001E9A70
	public void AddReceivedData(int level)
	{
		this.ReceivedSet.Add(level);
	}

	// Token: 0x0600604C RID: 24652 RVA: 0x001EB880 File Offset: 0x001E9A80
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

	// Token: 0x0600604D RID: 24653 RVA: 0x001EB8C4 File Offset: 0x001E9AC4
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

	// Token: 0x04003EFD RID: 16125
	private readonly HashSet<int> ReceivedSet = new HashSet<int>();

	// Token: 0x04003EFE RID: 16126
	private long ProtocolBeginOpenTime;
}
