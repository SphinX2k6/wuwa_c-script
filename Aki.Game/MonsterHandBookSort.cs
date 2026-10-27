using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200188B RID: 6283
public class MonsterHandBookSort : CommonSort<MonsterHandBookSort.EAdventureGuideSortType>
{
	// Token: 0x0600B80A RID: 47114 RVA: 0x0029AAB4 File Offset: 0x00298CB4
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

	// Token: 0x0600B80B RID: 47115 RVA: 0x0029ABC8 File Offset: 0x00298DC8
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(MonsterHandBookSort.EAdventureGuideSortType.Danger, new TSortResult(this.SortDanger));
	}

	// Token: 0x02007E37 RID: 32311
	public enum EAdventureGuideSortType
	{
		// Token: 0x040294EF RID: 169199
		Danger = 1
	}
}
