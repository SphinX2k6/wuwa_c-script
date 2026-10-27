using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02001872 RID: 6258
public class AdventureGuideSort : CommonSort<EAdventureGuideSortType>
{
	// Token: 0x0600B7B6 RID: 47030 RVA: 0x002993FC File Offset: 0x002975FC
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

	// Token: 0x0600B7B7 RID: 47031 RVA: 0x0029944C File Offset: 0x0029764C
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EAdventureGuideSortType.Danger, new TSortResult(this.SortDanger));
	}
}
