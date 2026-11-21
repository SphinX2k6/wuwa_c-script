using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000D52 RID: 3410
[NullableContext(1)]
[Nullable(0)]
public class VisionFetterSort : CommonSort<EVisionFetterSortWayType>
{
	// Token: 0x06008C59 RID: 35929 RVA: 0x002A8138 File Offset: 0x002A6338
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
					int num4 = (Array.IndexOf<int>(PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(phantomFetterGroup.Id), value) >= 0) ? 1 : -1;
					int num5 = (Array.IndexOf<int>(PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(phantomFetterGroup2.Id), value) >= 0) ? 1 : -1;
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

	// Token: 0x06008C5A RID: 35930 RVA: 0x002A8274 File Offset: 0x002A6474
	private int SortHaveState(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return 0;
	}

	// Token: 0x06008C5B RID: 35931 RVA: 0x002A8278 File Offset: 0x002A6478
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

	// Token: 0x06008C5C RID: 35932 RVA: 0x002A82D4 File Offset: 0x002A64D4
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EVisionFetterSortWayType.EquipState, new TSortResult(this.SortEquipState));
		this.SortMap.Add(EVisionFetterSortWayType.HaveState, new TSortResult(this.SortHaveState));
		this.SortMap.Add(EVisionFetterSortWayType.Id, new TSortResult(this.SortId));
	}
}
