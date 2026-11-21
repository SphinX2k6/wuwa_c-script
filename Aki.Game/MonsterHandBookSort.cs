using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000D44 RID: 3396
public class MonsterHandBookSort : CommonSort<MonsterHandBookSort.EAdventureGuideSortType>
{
	// Token: 0x06008BF3 RID: 35827 RVA: 0x002A51CC File Offset: 0x002A33CC
	[NullableContext(2)]
	private int SortDanger(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] parameters = null)
	{
		int num2;
		if (a is int)
		{
			int num = (int)a;
			num2 = num;
		}
		else
		{
			num2 = 0;
		}
		int id = num2;
		int num4;
		if (b is int)
		{
			int num3 = (int)b;
			num4 = num3;
		}
		else
		{
			num4 = 0;
		}
		int id2 = num4;
		HandBookConfig instance = HandBookConfig.Instance;
		MonsterHandBook? monsterHandBook = (instance != null) ? instance.GetMonsterHandBookConfigById(id) : null;
		HandBookConfig instance2 = HandBookConfig.Instance;
		MonsterHandBook? monsterHandBook2 = (instance2 != null) ? instance2.GetMonsterHandBookConfigById(id2) : null;
		int num5 = (monsterHandBook != null) ? monsterHandBook.GetValueOrDefault().Type : 0;
		int num6 = (monsterHandBook2 != null) ? monsterHandBook2.GetValueOrDefault().Type : 0;
		if (num5 != num6)
		{
			return (num5 - num6) * (isAscending ? 1 : -1);
		}
		int num7 = (monsterHandBook != null) ? monsterHandBook.GetValueOrDefault().SortId : 0;
		int num8 = (monsterHandBook2 != null) ? monsterHandBook2.GetValueOrDefault().SortId : 0;
		if (num7 != num8)
		{
			return (num8 - num7) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x06008BF4 RID: 35828 RVA: 0x002A52E0 File Offset: 0x002A34E0
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(MonsterHandBookSort.EAdventureGuideSortType.Danger, new TSortResult(this.SortDanger));
	}

	// Token: 0x02006FBE RID: 28606
	public enum EAdventureGuideSortType
	{
		// Token: 0x0402481C RID: 149532
		Danger = 1
	}
}
