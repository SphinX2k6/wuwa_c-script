using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039A RID: 922
	public static class IExploreSkillInteractTypeExtensions
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x0003D034 File Offset: 0x0003B234
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
									IExploreSkillGraffitiPuzzle exploreSkillGraffitiPuzzle = p as IExploreSkillGraffitiPuzzle;
									if (exploreSkillGraffitiPuzzle == null)
									{
										throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Actions的字段失败");
									}
									actions = exploreSkillGraffitiPuzzle.Actions;
								}
								else
								{
									actions = exploreSkillEavesdrop.Actions;
								}
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
