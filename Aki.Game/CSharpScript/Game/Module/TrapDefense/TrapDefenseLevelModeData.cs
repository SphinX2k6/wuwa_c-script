using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A2A RID: 18986
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelModeData : TrapDefenseLevelModeDataBase, ITrapDefenseLevelModeData<TrapDefenseLevelModeData>
	{
		// Token: 0x060314C3 RID: 201923 RVA: 0x00B6F5B4 File Offset: 0x00B6D7B4
		protected override void Init()
		{
		}

		// Token: 0x060314C4 RID: 201924 RVA: 0x00B6F5B6 File Offset: 0x00B6D7B6
		public List<ITrapDefenseDifficultyLevelInfo> GetDifficultyTypeList()
		{
			return new List<ITrapDefenseDifficultyLevelInfo>
			{
				TrapDefenseDefine.trapDefenseDifficultyLevelRecord[ETrapDefenseDifficultyLevel.Normal],
				TrapDefenseDefine.trapDefenseDifficultyLevelRecord[ETrapDefenseDifficultyLevel.Nightmare],
				TrapDefenseDefine.trapDefenseDifficultyLevelRecord[ETrapDefenseDifficultyLevel.Hell]
			};
		}

		// Token: 0x060314C5 RID: 201925 RVA: 0x00B6F5F0 File Offset: 0x00B6D7F0
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
