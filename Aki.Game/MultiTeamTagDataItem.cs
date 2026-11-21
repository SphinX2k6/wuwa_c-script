using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C75 RID: 7285
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamTagDataItem
{
	// Token: 0x0601211D RID: 74013 RVA: 0x0054FEF4 File Offset: 0x0054E0F4
	public static MultiTeamTagDataItem Phrase(int[] initSelectedTagList, ESkillBranchCacheType gameplayType)
	{
		return new MultiTeamTagDataItem
		{
			InitSelectedTagList = initSelectedTagList,
			GamePlayType = gameplayType
		};
	}

	// Token: 0x04009D87 RID: 40327
	public int[] InitSelectedTagList;

	// Token: 0x04009D88 RID: 40328
	public ESkillBranchCacheType GamePlayType = ESkillBranchCacheType.BossPiling;
}
