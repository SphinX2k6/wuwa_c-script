using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000351 RID: 849
	public static class IExploreSkillInteractTypeExtensions
	{
		// Token: 0x060010DC RID: 4316 RVA: 0x00039D68 File Offset: 0x00037F68
		[NullableContext(1)]
		public static IReadOnlyList<ActionInfo> GetActions(this IExploreSkillInteractType p)
		{
			IExploreSkillPullGiant exploreSkillPullGiant = p as IExploreSkillPullGiant;
			List<ActionInfo> actions;
			if (exploreSkillPullGiant == null)
			{
				IExploreSkillQuantumDiffusion exploreSkillQuantumDiffusion = p as IExploreSkillQuantumDiffusion;
				if (exploreSkillQuantumDiffusion == null)
				{
					IExploreSkillCustom exploreSkillCustom = p as IExploreSkillCustom;
					if (exploreSkillCustom == null)
					{
						IFoxJumpInteractPoint foxJumpInteractPoint = p as IFoxJumpInteractPoint;
						if (foxJumpInteractPoint == null)
						{
							IMonsterSummonInteractPoint monsterSummonInteractPoint = p as IMonsterSummonInteractPoint;
							if (monsterSummonInteractPoint == null)
							{
								IExploreSkillEavesdrop exploreSkillEavesdrop = p as IExploreSkillEavesdrop;
								if (exploreSkillEavesdrop == null)
								{
									throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Actions的字段失败");
								}
								actions = exploreSkillEavesdrop.Actions;
							}
							else
							{
								actions = monsterSummonInteractPoint.Actions;
							}
						}
						else
						{
							actions = foxJumpInteractPoint.Actions;
						}
					}
					else
					{
						actions = exploreSkillCustom.Actions;
					}
				}
				else
				{
					actions = exploreSkillQuantumDiffusion.Actions;
				}
			}
			else
			{
				actions = exploreSkillPullGiant.Actions;
			}
			return actions;
		}
	}
}
