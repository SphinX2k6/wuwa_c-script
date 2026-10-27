using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x0200244E RID: 9294
[NullableContext(1)]
[Nullable(0)]
public class VisionFetterRecommendInfo
{
	// Token: 0x06012A37 RID: 76343 RVA: 0x004990DD File Offset: 0x004972DD
	public VisionFetterRecommendInfo()
	{
		this.CountList = new List<IVisionFetterCount>();
		this.CostCombinations = new List<ICostCombinationData>();
	}

	// Token: 0x06012A38 RID: 76344 RVA: 0x00499106 File Offset: 0x00497306
	public int GetRecommendFetterGroupId()
	{
		return this.FetterGroupId;
	}

	// Token: 0x06012A39 RID: 76345 RVA: 0x0049910E File Offset: 0x0049730E
	public int GetSpecialFetterSubGroupId()
	{
		return this.FetterGroupSubId;
	}

	// Token: 0x06012A3A RID: 76346 RVA: 0x00499116 File Offset: 0x00497316
	public int GetPlanId()
	{
		return VisionFetterRecommendInfo.EncodePlanId(this.FetterGroupId, this.FetterGroupSubId);
	}

	// Token: 0x06012A3B RID: 76347 RVA: 0x00499129 File Offset: 0x00497329
	public int GetUsage()
	{
		return this.Usage;
	}

	// Token: 0x06012A3C RID: 76348 RVA: 0x00499134 File Offset: 0x00497334
	public string GetUsageText()
	{
		double num = (double)(this.Usage - this.Usage % 10) / 100.0;
		if (this.Usage != 0)
		{
			return num.ToString("F1") + "%";
		}
		return "";
	}

	// Token: 0x06012A3D RID: 76349 RVA: 0x00499181 File Offset: 0x00497381
	public List<IVisionFetterCount> GetFetterCountList()
	{
		return this.CountList;
	}

	// Token: 0x06012A3E RID: 76350 RVA: 0x00499189 File Offset: 0x00497389
	public EFetterGroupType GetFetterType()
	{
		return this.FetterGroupType;
	}

	// Token: 0x06012A3F RID: 76351 RVA: 0x00499191 File Offset: 0x00497391
	public List<ICostCombinationData> GetCostCombinations()
	{
		return this.CostCombinations;
	}

	// Token: 0x06012A40 RID: 76352 RVA: 0x00499199 File Offset: 0x00497399
	public List<global::MainPhantomRecommendInfo> GetMainPhantomList()
	{
		return this.MainPhantomList;
	}

	// Token: 0x06012A41 RID: 76353 RVA: 0x004991A4 File Offset: 0x004973A4
	public void Phrase(PhantomFetterRecommendInfo data)
	{
		this.PhraseIdAndCount(data);
		this.Usage = data.Usage;
		this.FetterGroupType = (EFetterGroupType)PhantomBattleConfig.Instance.GetFetterGroupById(this.FetterGroupId).FetterType;
		this.PhraseCostCombinations(data);
		this.PhraseMainPhantoms(data);
	}

	// Token: 0x06012A42 RID: 76354 RVA: 0x004991F0 File Offset: 0x004973F0
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

	// Token: 0x06012A43 RID: 76355 RVA: 0x00499294 File Offset: 0x00497494
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

	// Token: 0x06012A44 RID: 76356 RVA: 0x0049932C File Offset: 0x0049752C
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

	// Token: 0x06012A45 RID: 76357 RVA: 0x00499362 File Offset: 0x00497562
	public static int EncodePlanId(int fetterGroupId, int fetterGroupSubId)
	{
		if (fetterGroupSubId <= 0)
		{
			return fetterGroupId;
		}
		return fetterGroupId << 16 | (fetterGroupSubId & 65535);
	}

	// Token: 0x06012A46 RID: 76358 RVA: 0x00499378 File Offset: 0x00497578
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

	// Token: 0x06012A47 RID: 76359 RVA: 0x00499538 File Offset: 0x00497738
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

	// Token: 0x06012A48 RID: 76360 RVA: 0x004995C4 File Offset: 0x004977C4
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

	// Token: 0x04008C69 RID: 35945
	private const int COST_BITS = 4;

	// Token: 0x04008C6A RID: 35946
	private const int COST_MASK = 15;

	// Token: 0x04008C6B RID: 35947
	private const int PLAN_ID_GROUP_SHIFT = 16;

	// Token: 0x04008C6C RID: 35948
	private const int PLAN_ID_SUB_MASK = 65535;

	// Token: 0x04008C6D RID: 35949
	private int FetterGroupId;

	// Token: 0x04008C6E RID: 35950
	private int FetterGroupSubId;

	// Token: 0x04008C6F RID: 35951
	private int Usage;

	// Token: 0x04008C70 RID: 35952
	private EFetterGroupType FetterGroupType;

	// Token: 0x04008C71 RID: 35953
	private List<IVisionFetterCount> CountList;

	// Token: 0x04008C72 RID: 35954
	private List<ICostCombinationData> CostCombinations;

	// Token: 0x04008C73 RID: 35955
	private readonly List<global::MainPhantomRecommendInfo> MainPhantomList = new List<global::MainPhantomRecommendInfo>();
}
