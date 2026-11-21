using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000D2B RID: 3371
public class AdventureGuideSort : CommonSort<EAdventureGuideSortType>
{
	// Token: 0x06008B9F RID: 35743 RVA: 0x002A3B14 File Offset: 0x002A1D14
	[NullableContext(1)]
	private int SortDanger(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		MonsterDetectionRecord monsterDetectionRecord = a as MonsterDetectionRecord;
		if (monsterDetectionRecord == null)
		{
			return 0;
		}
		MonsterDetectionRecord monsterDetectionRecord2 = b as MonsterDetectionRecord;
		if (monsterDetectionRecord2 == null)
		{
			return 0;
		}
		if (monsterDetectionRecord != monsterDetectionRecord2)
		{
			return (monsterDetectionRecord.Conf.DangerType - monsterDetectionRecord2.Conf.DangerType) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x06008BA0 RID: 35744 RVA: 0x002A3B64 File Offset: 0x002A1D64
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EAdventureGuideSortType.Danger, new TSortResult(this.SortDanger));
	}
}
