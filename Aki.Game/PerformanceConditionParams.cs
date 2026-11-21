using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020025A0 RID: 9632
[NullableContext(1)]
[Nullable(0)]
public class PerformanceConditionParams
{
	// Token: 0x06017D67 RID: 97639 RVA: 0x00713310 File Offset: 0x00711510
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

	// Token: 0x0400CBA2 RID: 52130
	public List<HashSet<int>> DisableTagIds = new List<HashSet<int>>();

	// Token: 0x0400CBA3 RID: 52131
	public CharacterAnimationComponent AnimComp;

	// Token: 0x0400CBA4 RID: 52132
	public PerformanceCondition Config;
}
