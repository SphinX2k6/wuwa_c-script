using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039D2 RID: 14802
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelModeData : TrapDefenseLevelModeDataBase, ITrapDefenseLevelModeData<TrapDefenseLevelModeData>
	{
		// Token: 0x06026253 RID: 156243 RVA: 0x00AB3558 File Offset: 0x00AB1758
		protected override void Init()
		{
		}

		// Token: 0x06026254 RID: 156244 RVA: 0x00AB355A File Offset: 0x00AB175A
		public List<ITrapDefenseDifficultyLevelInfo> GetDifficultyTypeList()
		{
			return new List<ITrapDefenseDifficultyLevelInfo>
			{
				TrapDefenseDefine.trapDefenseDifficultyLevelRecord[ETrapDefenseDifficultyLevel.Normal],
				TrapDefenseDefine.trapDefenseDifficultyLevelRecord[ETrapDefenseDifficultyLevel.Nightmare],
				TrapDefenseDefine.trapDefenseDifficultyLevelRecord[ETrapDefenseDifficultyLevel.Hell]
			};
		}

		// Token: 0x06026255 RID: 156245 RVA: 0x00AB3594 File Offset: 0x00AB1794
		public List<TrapDefenseLevelData> GetLevelDataListByDifficulty(ETrapDefenseDifficultyLevel difficulty)
		{
			List<TrapDefenseLevelData> list = new List<TrapDefenseLevelData>();
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelDataList)
			{
				if (trapDefenseLevelData.IsDifficulty(difficulty))
				{
					list.Add(trapDefenseLevelData);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetPosition(i + 1);
			}
			return list;
		}
	}
}
