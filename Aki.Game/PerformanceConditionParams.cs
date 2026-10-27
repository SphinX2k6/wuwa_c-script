using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200304A RID: 12362
[NullableContext(1)]
[Nullable(0)]
public class PerformanceConditionParams
{
	// Token: 0x0601A3E7 RID: 107495 RVA: 0x006EBC28 File Offset: 0x006E9E28
	public PerformanceConditionParams(CharacterAnimationComponent animComp, PerformanceCondition config)
	{
		this.AnimComp = animComp;
		this.Config = config;
		for (int i = 0; i < 3; i++)
		{
			this.DisableTagIds.Add(new HashSet<int>());
			GameplayTagArray? gameplayTagArray = config.DisableTags(i);
			for (int j = 0; j < gameplayTagArray.Value.ArrayStringLength; j++)
			{
				int tagIdByName = GameplayTagUtils.GetTagIdByName(gameplayTagArray.Value.ArrayString(j));
				if (tagIdByName != 0)
				{
					this.DisableTagIds[i].Add(tagIdByName);
				}
			}
		}
	}

	// Token: 0x0400C7C8 RID: 51144
	public List<HashSet<int>> DisableTagIds = new List<HashSet<int>>();

	// Token: 0x0400C7C9 RID: 51145
	public CharacterAnimationComponent AnimComp;

	// Token: 0x0400C7CA RID: 51146
	public PerformanceCondition Config;
}
