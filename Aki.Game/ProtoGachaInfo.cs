using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02001167 RID: 4455
[NullableContext(1)]
[Nullable(0)]
public class ProtoGachaInfo
{
	// Token: 0x0600B18F RID: 45455 RVA: 0x0034810C File Offset: 0x0034630C
	public ProtoGachaInfo(GachaInfo gachaInfo)
	{
		this.Id = gachaInfo.Id;
		this.TodayTimes = gachaInfo.TodayTimes;
		this.TotalTimes = gachaInfo.TotalTimes;
		this.ItemId = gachaInfo.ItemId;
		GachaConsume[] array = new GachaConsume[gachaInfo.GachaConsumes.Count];
		gachaInfo.GachaConsumes.CopyTo(array, 0);
		this.GachaConsumes = array;
		this.UsePoolId = gachaInfo.UsePoolId;
		this.GachaAccumulateId = gachaInfo.GachaAccumulateId;
		GachaDiscountInfo[] array2 = new GachaDiscountInfo[gachaInfo.GachaDiscountInfos.Count];
		gachaInfo.GachaDiscountInfos.CopyTo(array2, 0);
		this.GachaDiscountInfos = array2;
		this.OnlyViewDiscount = gachaInfo.OnlyViewDiscount;
		this.IsShowProgress = gachaInfo.IsShowProgress;
		foreach (KeyValuePair<int, string> keyValuePair in gachaInfo.DiscountTagDetails)
		{
			this.DiscountTagDetails[keyValuePair.Key] = keyValuePair.Value;
		}
		RepeatedField<GachaPoolInfo> pools = gachaInfo.Pools;
		if (pools != null)
		{
			List<ProtoGachaPoolInfo> list = new List<ProtoGachaPoolInfo>();
			foreach (GachaPoolInfo poolInfo in pools)
			{
				list.Add(new ProtoGachaPoolInfo(poolInfo));
			}
			this.Pools = list.ToArray();
		}
		this.BeginTime = (double)MathUtils.Instance.LongToNumber(gachaInfo.BeginTime);
		this.EndTime = (double)MathUtils.Instance.LongToNumber(gachaInfo.EndTime);
		this.DailyLimitTimes = gachaInfo.DailyLimitTimes;
		this.TotalLimitTimes = gachaInfo.TotalLimitTimes;
		this.ResourcesId = gachaInfo.ResourcesId;
		Gacha? gachaConfig = GachaConfig.Instance.GetGachaConfig(this.Id);
		if (gachaConfig != null)
		{
			this.Sort = gachaConfig.Value.Sort;
			this.GroupId = gachaConfig.Value.RuleGroupId;
		}
	}

	// Token: 0x0600B190 RID: 45456 RVA: 0x00348348 File Offset: 0x00346548
	[NullableContext(2)]
	public ProtoGachaPoolInfo GetFirstValidPool()
	{
		ProtoGachaPoolInfo[] validPoolList = this.GetValidPoolList();
		if (validPoolList != null && validPoolList.Length != 0)
		{
			return validPoolList[0];
		}
		return null;
	}

	// Token: 0x0600B191 RID: 45457 RVA: 0x00348368 File Offset: 0x00346568
	[NullableContext(2)]
	public ProtoGachaPoolInfo GetPoolInfo(int poolId)
	{
		ProtoGachaPoolInfo result = null;
		foreach (ProtoGachaPoolInfo protoGachaPoolInfo in this.Pools)
		{
			if (protoGachaPoolInfo.Id == poolId)
			{
				result = protoGachaPoolInfo;
			}
		}
		return result;
	}

	// Token: 0x0600B192 RID: 45458 RVA: 0x0034839C File Offset: 0x0034659C
	[NullableContext(2)]
	public ProtoGachaPoolInfo GetCurrentPoolInfo()
	{
		if (this.UsePoolId == 0)
		{
			Log.Instance.Error(ELogModule.Gacha, ELogAuthor.LPH, "ProtoGachaInfo.GetCurrentPoolInfo UsePoolId is 0!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return this.GetPoolInfo(this.UsePoolId);
	}

	// Token: 0x0600B193 RID: 45459 RVA: 0x003483E0 File Offset: 0x003465E0
	public double GetPoolEndTimeByPoolId(int poolId)
	{
		ProtoGachaPoolInfo poolInfo = this.GetPoolInfo(poolId);
		return this.GetPoolEndTimeByPoolInfo(poolInfo);
	}

	// Token: 0x0600B194 RID: 45460 RVA: 0x003483FC File Offset: 0x003465FC
	[NullableContext(2)]
	public double GetPoolEndTimeByPoolInfo(ProtoGachaPoolInfo poolInfo)
	{
		double endTime = this.EndTime;
		if (poolInfo == null)
		{
			return endTime;
		}
		double endTime2 = poolInfo.EndTime;
		if (endTime2 == 0.0)
		{
			return endTime;
		}
		if (endTime == 0.0)
		{
			return endTime2;
		}
		if (endTime >= endTime2)
		{
			return endTime2;
		}
		return endTime;
	}

	// Token: 0x0600B195 RID: 45461 RVA: 0x00348440 File Offset: 0x00346640
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public ProtoGachaPoolInfo[] GetValidPoolList()
	{
		ProtoGachaPoolInfo[] pools = this.Pools;
		if (pools == null)
		{
			return null;
		}
		List<ProtoGachaPoolInfo> list = new List<ProtoGachaPoolInfo>();
		foreach (ProtoGachaPoolInfo protoGachaPoolInfo in pools)
		{
			if (this.IsPoolValid(protoGachaPoolInfo))
			{
				list.Add(protoGachaPoolInfo);
			}
		}
		list.Sort((ProtoGachaPoolInfo a, ProtoGachaPoolInfo b) => a.Sort - b.Sort);
		return list.ToArray();
	}

	// Token: 0x0600B196 RID: 45462 RVA: 0x003484B4 File Offset: 0x003466B4
	public bool IsPoolValid(ProtoGachaPoolInfo poolInfo)
	{
		double poolEndTimeByPoolInfo = this.GetPoolEndTimeByPoolInfo(poolInfo);
		return poolEndTimeByPoolInfo == 0.0 || poolEndTimeByPoolInfo >= TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x0400667A RID: 26234
	public readonly int Id;

	// Token: 0x0400667B RID: 26235
	public int TodayTimes;

	// Token: 0x0400667C RID: 26236
	public int TotalTimes;

	// Token: 0x0400667D RID: 26237
	public readonly int ItemId;

	// Token: 0x0400667E RID: 26238
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public readonly GachaConsume[] GachaConsumes;

	// Token: 0x0400667F RID: 26239
	public int UsePoolId;

	// Token: 0x04006680 RID: 26240
	private readonly ProtoGachaPoolInfo[] Pools = Array.Empty<ProtoGachaPoolInfo>();

	// Token: 0x04006681 RID: 26241
	public readonly double BeginTime;

	// Token: 0x04006682 RID: 26242
	public readonly double EndTime;

	// Token: 0x04006683 RID: 26243
	public readonly int DailyLimitTimes;

	// Token: 0x04006684 RID: 26244
	public readonly int TotalLimitTimes;

	// Token: 0x04006685 RID: 26245
	public readonly string ResourcesId = "";

	// Token: 0x04006686 RID: 26246
	public int GroupId;

	// Token: 0x04006687 RID: 26247
	public int Sort;

	// Token: 0x04006688 RID: 26248
	public int GachaAccumulateId;

	// Token: 0x04006689 RID: 26249
	public GachaDiscountInfo[] GachaDiscountInfos = Array.Empty<GachaDiscountInfo>();

	// Token: 0x0400668A RID: 26250
	public bool OnlyViewDiscount;

	// Token: 0x0400668B RID: 26251
	public bool IsShowProgress;

	// Token: 0x0400668C RID: 26252
	public Dictionary<int, string> DiscountTagDetails = new Dictionary<int, string>();
}
