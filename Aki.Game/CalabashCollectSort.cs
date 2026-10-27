using System;
using System.Runtime.CompilerServices;

// Token: 0x02001876 RID: 6262
[NullableContext(1)]
[Nullable(0)]
public class CalabashCollectSort : CommonSort<ECalabashCollectWayType>
{
	// Token: 0x0600B7C0 RID: 47040 RVA: 0x00299674 File Offset: 0x00297874
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		CalabashDevelopRewardData calabashDevelopRewardData = a as CalabashDevelopRewardData;
		if (calabashDevelopRewardData == null)
		{
			return 0;
		}
		CalabashDevelopRewardData calabashDevelopRewardData2 = b as CalabashDevelopRewardData;
		if (calabashDevelopRewardData2 == null)
		{
			return 0;
		}
		int monsterId = calabashDevelopRewardData.DevelopRewardData.MonsterId;
		int monsterRarity = PhantomBattleModel.Instance.GetMonsterRarity(monsterId);
		int monsterId2 = calabashDevelopRewardData2.DevelopRewardData.MonsterId;
		int monsterRarity2 = PhantomBattleModel.Instance.GetMonsterRarity(monsterId2);
		if (monsterRarity != monsterRarity2)
		{
			return (monsterRarity - monsterRarity2) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x0600B7C1 RID: 47041 RVA: 0x002996E8 File Offset: 0x002978E8
	private int SortSortId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		CalabashDevelopRewardData calabashDevelopRewardData = a as CalabashDevelopRewardData;
		if (calabashDevelopRewardData == null)
		{
			return 0;
		}
		CalabashDevelopRewardData calabashDevelopRewardData2 = b as CalabashDevelopRewardData;
		if (calabashDevelopRewardData2 == null)
		{
			return 0;
		}
		int sortId = calabashDevelopRewardData.DevelopRewardData.SortId;
		int sortId2 = calabashDevelopRewardData2.DevelopRewardData.SortId;
		if (sortId != sortId2)
		{
			return (sortId - sortId2) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x0600B7C2 RID: 47042 RVA: 0x00299740 File Offset: 0x00297940
	private int SortMonsterId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		CalabashDevelopRewardData calabashDevelopRewardData = a as CalabashDevelopRewardData;
		if (calabashDevelopRewardData == null)
		{
			return 0;
		}
		CalabashDevelopRewardData calabashDevelopRewardData2 = b as CalabashDevelopRewardData;
		if (calabashDevelopRewardData2 == null)
		{
			return 0;
		}
		int monsterId = calabashDevelopRewardData.DevelopRewardData.MonsterId;
		int monsterId2 = calabashDevelopRewardData2.DevelopRewardData.MonsterId;
		if (monsterId != monsterId2)
		{
			return (monsterId - monsterId2) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x0600B7C3 RID: 47043 RVA: 0x00299798 File Offset: 0x00297998
	private int SortExperience(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		CalabashDevelopRewardData calabashDevelopRewardData = a as CalabashDevelopRewardData;
		if (calabashDevelopRewardData == null)
		{
			return 0;
		}
		CalabashDevelopRewardData calabashDevelopRewardData2 = b as CalabashDevelopRewardData;
		if (calabashDevelopRewardData2 == null)
		{
			return 0;
		}
		int monsterId = calabashDevelopRewardData.DevelopRewardData.MonsterId;
		int monsterId2 = calabashDevelopRewardData2.DevelopRewardData.MonsterId;
		int calabashDevelopRewardExpByMonsterId = CalabashModel.Instance.GetCalabashDevelopRewardExpByMonsterId(monsterId);
		int calabashDevelopRewardExpByMonsterId2 = CalabashModel.Instance.GetCalabashDevelopRewardExpByMonsterId(monsterId2);
		if (calabashDevelopRewardExpByMonsterId != calabashDevelopRewardExpByMonsterId2)
		{
			return (calabashDevelopRewardExpByMonsterId - calabashDevelopRewardExpByMonsterId2) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x0600B7C4 RID: 47044 RVA: 0x0029980C File Offset: 0x00297A0C
	private int SortSkin(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		CalabashDevelopRewardData calabashDevelopRewardData = a as CalabashDevelopRewardData;
		if (calabashDevelopRewardData == null)
		{
			return 0;
		}
		CalabashDevelopRewardData calabashDevelopRewardData2 = b as CalabashDevelopRewardData;
		if (calabashDevelopRewardData2 == null)
		{
			return 0;
		}
		int monsterId = calabashDevelopRewardData.DevelopRewardData.MonsterId;
		int monsterId2 = calabashDevelopRewardData2.DevelopRewardData.MonsterId;
		int[] monsterSkinListByMonsterId = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(monsterId);
		int num = (monsterSkinListByMonsterId != null) ? monsterSkinListByMonsterId.Length : 0;
		int[] monsterSkinListByMonsterId2 = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(monsterId2);
		int num2 = (monsterSkinListByMonsterId2 != null) ? monsterSkinListByMonsterId2.Length : 0;
		if (num != num2)
		{
			return (num - num2) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x0600B7C5 RID: 47045 RVA: 0x00299894 File Offset: 0x00297A94
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(ECalabashCollectWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(ECalabashCollectWayType.SortId, new TSortResult(this.SortSortId));
		this.SortMap.Add(ECalabashCollectWayType.MonsterId, new TSortResult(this.SortMonsterId));
		this.SortMap.Add(ECalabashCollectWayType.Experience, new TSortResult(this.SortExperience));
		this.SortMap.Add(ECalabashCollectWayType.Skin, new TSortResult(this.SortSkin));
	}
}
