using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02001CA8 RID: 7336
[NullableContext(1)]
[Nullable(0)]
public class ProtoGachaInfo
{
	// Token: 0x0600DD79 RID: 56697 RVA: 0x0033CC80 File Offset: 0x0033AE80
	public ProtoGachaInfo(GachaInfo gachaInfo)
	{
		this.Id = gachaInfo.Id;
		this.TodayTimes = gachaInfo.TodayTimes;
		this.TotalTimes = gachaInfo.TotalTimes;
		this.ItemId = gachaInfo.ItemId;
		this.GachaConsumes = gachaInfo.GachaConsumes.ToArray<GachaConsume>();
		this.UsePoolId = gachaInfo.UsePoolId;
		this.GachaAccumulateId = gachaInfo.GachaAccumulateId;
		this.GachaDiscountInfos = gachaInfo.GachaDiscountInfos.ToArray<GachaDiscountInfo>();
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

	// Token: 0x0600DD7A RID: 56698 RVA: 0x0033CE90 File Offset: 0x0033B090
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

	// Token: 0x0600DD7B RID: 56699 RVA: 0x0033CEB0 File Offset: 0x0033B0B0
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

	// Token: 0x0600DD7C RID: 56700 RVA: 0x0033CEE4 File Offset: 0x0033B0E4
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

	// Token: 0x0600DD7D RID: 56701 RVA: 0x0033CF28 File Offset: 0x0033B128
	public double GetPoolEndTimeByPoolId(int poolId)
	{
		ProtoGachaPoolInfo poolInfo = this.GetPoolInfo(poolId);
		return this.GetPoolEndTimeByPoolInfo(poolInfo);
	}

	// Token: 0x0600DD7E RID: 56702 RVA: 0x0033CF44 File Offset: 0x0033B144
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

	// Token: 0x0600DD7F RID: 56703 RVA: 0x0033CF88 File Offset: 0x0033B188
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

	// Token: 0x0600DD80 RID: 56704 RVA: 0x0033CFFC File Offset: 0x0033B1FC
	public bool IsPoolValid(ProtoGachaPoolInfo poolInfo)
	{
		double poolEndTimeByPoolInfo = this.GetPoolEndTimeByPoolInfo(poolInfo);
		return poolEndTimeByPoolInfo == 0.0 || poolEndTimeByPoolInfo >= TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x040065A9 RID: 26025
	public readonly int Id;

	// Token: 0x040065AA RID: 26026
	public int TodayTimes;

	// Token: 0x040065AB RID: 26027
	public int TotalTimes;

	// Token: 0x040065AC RID: 26028
	public readonly int ItemId;

	// Token: 0x040065AD RID: 26029
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public readonly GachaConsume[] GachaConsumes;

	// Token: 0x040065AE RID: 26030
	public int UsePoolId;

	// Token: 0x040065AF RID: 26031
	private readonly ProtoGachaPoolInfo[] Pools = Array.Empty<ProtoGachaPoolInfo>();

	// Token: 0x040065B0 RID: 26032
	public readonly double BeginTime;

	// Token: 0x040065B1 RID: 26033
	public readonly double EndTime;

	// Token: 0x040065B2 RID: 26034
	public readonly int DailyLimitTimes;

	// Token: 0x040065B3 RID: 26035
	public readonly int TotalLimitTimes;

	// Token: 0x040065B4 RID: 26036
	public readonly string ResourcesId = "";

	// Token: 0x040065B5 RID: 26037
	public int GroupId;

	// Token: 0x040065B6 RID: 26038
	public int Sort;

	// Token: 0x040065B7 RID: 26039
	public int GachaAccumulateId;

	// Token: 0x040065B8 RID: 26040
	public GachaDiscountInfo[] GachaDiscountInfos = Array.Empty<GachaDiscountInfo>();

	// Token: 0x040065B9 RID: 26041
	public bool OnlyViewDiscount;

	// Token: 0x040065BA RID: 26042
	public bool IsShowProgress;

	// Token: 0x040065BB RID: 26043
	public Dictionary<int, string> DiscountTagDetails = new Dictionary<int, string>();
}
