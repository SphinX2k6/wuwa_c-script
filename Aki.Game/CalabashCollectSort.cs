using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D2F RID: 3375
[NullableContext(1)]
[Nullable(0)]
public class CalabashCollectSort : CommonSort<ECalabashCollectWayType>
{
	// Token: 0x06008BA9 RID: 35753 RVA: 0x002A3D8C File Offset: 0x002A1F8C
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

	// Token: 0x06008BAA RID: 35754 RVA: 0x002A3E00 File Offset: 0x002A2000
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

	// Token: 0x06008BAB RID: 35755 RVA: 0x002A3E58 File Offset: 0x002A2058
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

	// Token: 0x06008BAC RID: 35756 RVA: 0x002A3EB0 File Offset: 0x002A20B0
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

	// Token: 0x06008BAD RID: 35757 RVA: 0x002A3F24 File Offset: 0x002A2124
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

	// Token: 0x06008BAE RID: 35758 RVA: 0x002A3FAC File Offset: 0x002A21AC
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(ECalabashCollectWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(ECalabashCollectWayType.SortId, new TSortResult(this.SortSortId));
		this.SortMap.Add(ECalabashCollectWayType.MonsterId, new TSortResult(this.SortMonsterId));
		this.SortMap.Add(ECalabashCollectWayType.Experience, new TSortResult(this.SortExperience));
		this.SortMap.Add(ECalabashCollectWayType.Skin, new TSortResult(this.SortSkin));
	}
}
