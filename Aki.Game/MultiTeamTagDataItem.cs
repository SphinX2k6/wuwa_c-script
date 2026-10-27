using System;
using System.Runtime.CompilerServices;

// Token: 0x0200278A RID: 10122
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamTagDataItem
{
	// Token: 0x06014C33 RID: 85043 RVA: 0x00540F14 File Offset: 0x0053F114
	public static MultiTeamTagDataItem Phrase(int[] initSelectedTagList, ESkillBranchCacheType gameplayType)
	{
		return new MultiTeamTagDataItem
		{
			InitSelectedTagList = initSelectedTagList,
			GamePlayType = gameplayType
		};
	}

	// Token: 0x04009C27 RID: 39975
	public int[] InitSelectedTagList;

	// Token: 0x04009C28 RID: 39976
	public ESkillBranchCacheType GamePlayType = ESkillBranchCacheType.BossPiling;
}
