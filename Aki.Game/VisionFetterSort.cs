using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001899 RID: 6297
[NullableContext(1)]
[Nullable(0)]
public class VisionFetterSort : CommonSort<EVisionFetterSortWayType>
{
	// Token: 0x0600B870 RID: 47216 RVA: 0x0029DA20 File Offset: 0x0029BC20
	private int SortEquipState(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		if (!(a is PhantomFetterGroup))
		{
			return 0;
		}
		PhantomFetterGroup phantomFetterGroup = (PhantomFetterGroup)a;
		if (b is PhantomFetterGroup)
		{
			PhantomFetterGroup phantomFetterGroup2 = (PhantomFetterGroup)b;
			int num = 0;
			if (param != null && param.Length != 0)
			{
				object obj = param[0];
				if (obj is int)
				{
					int num2 = (int)obj;
					num = num2;
				}
			}
			int num3 = num;
			if (num3 > 0)
			{
				foreach (int uniqueId in PhantomBattleModel.Instance.GetBattleDataById(num3).GetIncrIdList())
				{
					PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
					int value = (phantomBattleData != null) ? phantomBattleData.GetMonsterId(false) : 0;
					int num4 = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(phantomFetterGroup.Id).Contains(value) ? 1 : -1;
					int num5 = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(phantomFetterGroup2.Id).Contains(value) ? 1 : -1;
					if (num4 != num5)
					{
						return (num4 > num5) ? (isAscending ? 1 : -1) : (isAscending ? -1 : 1);
					}
				}
				return 0;
			}
			return 0;
		}
		return 0;
	}

	// Token: 0x0600B871 RID: 47217 RVA: 0x0029DB58 File Offset: 0x0029BD58
	private int SortHaveState(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return 0;
	}

	// Token: 0x0600B872 RID: 47218 RVA: 0x0029DB5C File Offset: 0x0029BD5C
	private int SortId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		if (!(a is PhantomFetterGroup))
		{
			return 0;
		}
		PhantomFetterGroup phantomFetterGroup = (PhantomFetterGroup)a;
		if (!(b is PhantomFetterGroup))
		{
			return 0;
		}
		PhantomFetterGroup phantomFetterGroup2 = (PhantomFetterGroup)b;
		if (phantomFetterGroup.SortId != phantomFetterGroup2.SortId)
		{
			return (phantomFetterGroup.SortId - phantomFetterGroup2.SortId) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x0600B873 RID: 47219 RVA: 0x0029DBB8 File Offset: 0x0029BDB8
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EVisionFetterSortWayType.EquipState, new TSortResult(this.SortEquipState));
		this.SortMap.Add(EVisionFetterSortWayType.HaveState, new TSortResult(this.SortHaveState));
		this.SortMap.Add(EVisionFetterSortWayType.Id, new TSortResult(this.SortId));
	}
}
