using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02001933 RID: 6451
[NullableContext(1)]
[Nullable(0)]
public class VisionFetterRecommendInfo
{
	// Token: 0x0600FEEE RID: 65262 RVA: 0x004A66E5 File Offset: 0x004A48E5
	public VisionFetterRecommendInfo()
	{
		this.CountList = new List<IVisionFetterCount>();
		this.CostCombinations = new List<ICostCombinationData>();
	}

	// Token: 0x0600FEEF RID: 65263 RVA: 0x004A670E File Offset: 0x004A490E
	public int GetRecommendFetterGroupId()
	{
		return this.FetterGroupId;
	}

	// Token: 0x0600FEF0 RID: 65264 RVA: 0x004A6716 File Offset: 0x004A4916
	public int GetSpecialFetterSubGroupId()
	{
		return this.FetterGroupSubId;
	}

	// Token: 0x0600FEF1 RID: 65265 RVA: 0x004A671E File Offset: 0x004A491E
	public int GetPlanId()
	{
		return VisionFetterRecommendInfo.EncodePlanId(this.FetterGroupId, this.FetterGroupSubId);
	}

	// Token: 0x0600FEF2 RID: 65266 RVA: 0x004A6731 File Offset: 0x004A4931
	public int GetUsage()
	{
		return this.Usage;
	}

	// Token: 0x0600FEF3 RID: 65267 RVA: 0x004A673C File Offset: 0x004A493C
	public string GetUsageText()
	{
		double num = (double)(this.Usage - this.Usage % 10) / 100.0;
		if (this.Usage != 0)
		{
			return num.ToString("F1") + "%";
		}
		return "";
	}

	// Token: 0x0600FEF4 RID: 65268 RVA: 0x004A6789 File Offset: 0x004A4989
	public List<IVisionFetterCount> GetFetterCountList()
	{
		return this.CountList;
	}

	// Token: 0x0600FEF5 RID: 65269 RVA: 0x004A6791 File Offset: 0x004A4991
	public EFetterGroupType GetFetterType()
	{
		return this.FetterGroupType;
	}

	// Token: 0x0600FEF6 RID: 65270 RVA: 0x004A6799 File Offset: 0x004A4999
	public List<ICostCombinationData> GetCostCombinations()
	{
		return this.CostCombinations;
	}

	// Token: 0x0600FEF7 RID: 65271 RVA: 0x004A67A1 File Offset: 0x004A49A1
	public List<global::MainPhantomRecommendInfo> GetMainPhantomList()
	{
		return this.MainPhantomList;
	}

	// Token: 0x0600FEF8 RID: 65272 RVA: 0x004A67AC File Offset: 0x004A49AC
	public void Phrase(PhantomFetterRecommendInfo data)
	{
		this.PhraseIdAndCount(data);
		this.Usage = data.Usage;
		this.FetterGroupType = (EFetterGroupType)PhantomBattleConfig.Instance.GetFetterGroupById(this.FetterGroupId).FetterType;
		this.PhraseCostCombinations(data);
		this.PhraseMainPhantoms(data);
	}

	// Token: 0x0600FEF9 RID: 65273 RVA: 0x004A67F8 File Offset: 0x004A49F8
	private void PhraseMainPhantoms(PhantomFetterRecommendInfo data)
	{
		this.MainPhantomList.Clear();
		RepeatedField<Aki.Protocol.MainPhantomRecommendInfo> mainPhantomRecommendInfos = data.MainPhantomRecommendInfos;
		if (mainPhantomRecommendInfos == null || mainPhantomRecommendInfos.Count == 0)
		{
			return;
		}
		foreach (Aki.Protocol.MainPhantomRecommendInfo data2 in mainPhantomRecommendInfos)
		{
			global::MainPhantomRecommendInfo mainPhantomRecommendInfo = new global::MainPhantomRecommendInfo();
			mainPhantomRecommendInfo.Phrase(data2);
			this.MainPhantomList.Add(mainPhantomRecommendInfo);
		}
		this.MainPhantomList.Sort((global::MainPhantomRecommendInfo a, global::MainPhantomRecommendInfo b) => b.GetUsage() - a.GetUsage());
	}

	// Token: 0x0600FEFA RID: 65274 RVA: 0x004A689C File Offset: 0x004A4A9C
	private void PhraseCostCombinations(PhantomFetterRecommendInfo data)
	{
		this.CostCombinations = new List<ICostCombinationData>();
		RepeatedField<CostCombinationInfo> costCombinationInfos = data.CostCombinationInfos;
		if (costCombinationInfos == null || costCombinationInfos.Count == 0)
		{
			return;
		}
		foreach (CostCombinationInfo costCombinationInfo in costCombinationInfos)
		{
			int costId = costCombinationInfo.CostId;
			this.CostCombinations.Add(new CostCombinationData
			{
				CostId = costId,
				Costs = VisionFetterRecommendInfo.DecodeCostId(costId),
				Usage = costCombinationInfo.Usage
			});
		}
	}

	// Token: 0x0600FEFB RID: 65275 RVA: 0x004A6934 File Offset: 0x004A4B34
	public static List<int> DecodeCostId(int costId)
	{
		List<int> list = new List<int>();
		for (int i = 28; i >= 0; i -= 4)
		{
			int num = (int)((uint)costId >> i & 15U);
			if (num > 0)
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x0600FEFC RID: 65276 RVA: 0x004A696A File Offset: 0x004A4B6A
	public static int EncodePlanId(int fetterGroupId, int fetterGroupSubId)
	{
		if (fetterGroupSubId <= 0)
		{
			return fetterGroupId;
		}
		return fetterGroupId << 16 | (fetterGroupSubId & 65535);
	}

	// Token: 0x0600FEFD RID: 65277 RVA: 0x004A6980 File Offset: 0x004A4B80
	private unsafe void PhraseIdAndCount(PhantomFetterRecommendInfo data)
	{
		this.CountList = new List<IVisionFetterCount>();
		RepeatedField<PhantomFetterGroupInfo> phantomFetterGroupInfos = data.PhantomFetterGroupInfos;
		if (phantomFetterGroupInfos.Count < 2 || phantomFetterGroupInfos.Count > 3)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.WDX, "推荐的套装羁绊数量异常，请确认配置与统计", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		int? num = null;
		int? num2 = null;
		foreach (PhantomFetterGroupInfo phantomFetterGroupInfo in phantomFetterGroupInfos)
		{
			int phantomFetterGroupId = phantomFetterGroupInfo.PhantomFetterGroupId;
			int countNeed = phantomFetterGroupInfo.CountNeed;
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(phantomFetterGroupId);
			if (fetterGroupById.FetterType == 1)
			{
				num = new int?(phantomFetterGroupId);
			}
			else
			{
				num2 = new int?(phantomFetterGroupId);
			}
			int fetterId;
			if (!fetterGroupById.FetterMap().TryGetValue(countNeed, out fetterId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Phantom;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "推荐的套装没有对应的羁绊效果";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Group", phantomFetterGroupId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Count", countNeed);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				VisionFetterCount item = new VisionFetterCount
				{
					GroupId = phantomFetterGroupId,
					Count = countNeed,
					FetterId = fetterId
				};
				this.CountList.Add(item);
			}
		}
		this.FetterGroupId = (num ?? ((phantomFetterGroupInfos.Count > 0) ? phantomFetterGroupInfos[0].PhantomFetterGroupId : 0));
		this.FetterGroupSubId = ((num != null) ? num2.GetValueOrDefault() : 0);
	}

	// Token: 0x0600FEFE RID: 65278 RVA: 0x004A6B40 File Offset: 0x004A4D40
	public List<int> BuildFetterList()
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (IVisionFetterCount visionFetterCount in this.GetFetterCountList())
		{
			hashSet.Add(visionFetterCount.GroupId);
		}
		List<int> list = new List<int>(hashSet);
		list.Sort(delegate(int a, int b)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(a);
			PhantomFetterGroup fetterGroupById2 = PhantomBattleConfig.Instance.GetFetterGroupById(b);
			if (fetterGroupById.FetterType != fetterGroupById2.FetterType)
			{
				return fetterGroupById2.FetterType - fetterGroupById.FetterType;
			}
			return b - a;
		});
		return list;
	}

	// Token: 0x0600FEFF RID: 65279 RVA: 0x004A6BCC File Offset: 0x004A4DCC
	public List<IVisionNewRecommendFetterItemData> BuildFetterItemDataList()
	{
		Dictionary<int, IVisionNewRecommendFetterItemData> dictionary = new Dictionary<int, IVisionNewRecommendFetterItemData>();
		foreach (IVisionFetterCount visionFetterCount in this.GetFetterCountList())
		{
			IVisionNewRecommendFetterItemData visionNewRecommendFetterItemData;
			if (dictionary.TryGetValue(visionFetterCount.GroupId, out visionNewRecommendFetterItemData))
			{
				visionNewRecommendFetterItemData.Count = Math.Max(visionNewRecommendFetterItemData.Count, visionFetterCount.Count);
			}
			else
			{
				visionNewRecommendFetterItemData = new VisionNewRecommendFetterItemData
				{
					GroupId = visionFetterCount.GroupId,
					Count = visionFetterCount.Count
				};
				dictionary[visionFetterCount.GroupId] = visionNewRecommendFetterItemData;
			}
		}
		List<IVisionNewRecommendFetterItemData> list = new List<IVisionNewRecommendFetterItemData>(dictionary.Values);
		list.Sort(delegate(IVisionNewRecommendFetterItemData a, IVisionNewRecommendFetterItemData b)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(a.GroupId);
			PhantomFetterGroup fetterGroupById2 = PhantomBattleConfig.Instance.GetFetterGroupById(b.GroupId);
			if (fetterGroupById.FetterType != fetterGroupById2.FetterType)
			{
				return fetterGroupById2.FetterType - fetterGroupById.FetterType;
			}
			return b.GroupId - a.GroupId;
		});
		return list;
	}

	// Token: 0x04008DB0 RID: 36272
	private const int COST_BITS = 4;

	// Token: 0x04008DB1 RID: 36273
	private const int COST_MASK = 15;

	// Token: 0x04008DB2 RID: 36274
	private const int PLAN_ID_GROUP_SHIFT = 16;

	// Token: 0x04008DB3 RID: 36275
	private const int PLAN_ID_SUB_MASK = 65535;

	// Token: 0x04008DB4 RID: 36276
	private int FetterGroupId;

	// Token: 0x04008DB5 RID: 36277
	private int FetterGroupSubId;

	// Token: 0x04008DB6 RID: 36278
	private int Usage;

	// Token: 0x04008DB7 RID: 36279
	private EFetterGroupType FetterGroupType;

	// Token: 0x04008DB8 RID: 36280
	private List<IVisionFetterCount> CountList;

	// Token: 0x04008DB9 RID: 36281
	private List<ICostCombinationData> CostCombinations;

	// Token: 0x04008DBA RID: 36282
	private readonly List<global::MainPhantomRecommendInfo> MainPhantomList = new List<global::MainPhantomRecommendInfo>();
}
