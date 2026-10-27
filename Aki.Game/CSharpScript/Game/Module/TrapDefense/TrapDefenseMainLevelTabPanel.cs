using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AB7 RID: 19127
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseMainLevelTabPanel : TrapDefenseLevelTabPanel<TrapDefenseLevelModeData>
	{
		// Token: 0x060318E5 RID: 202981 RVA: 0x00B7DD7F File Offset: 0x00B7BF7F
		public TrapDefenseMainLevelTabPanel()
		{
			this.ModeData = TrapDefenseModel.Instance.LevelModeData;
		}

		// Token: 0x060318E6 RID: 202982 RVA: 0x00B7DDA0 File Offset: 0x00B7BFA0
		protected override void OnStart()
		{
			this.PanelDifficultyChange.SetActive(true);
			this.PanelDifficultyChange.OnSelectDifficultyCallback = new Action<ITrapDefenseDifficultyLevelInfo>(this.OnSelectDifficulty);
			this.PanelDifficultyChange.OnRedDotLeftVisibleCallback = new Func<int, bool>(this.OnRedDotLeftVisible);
			this.PanelDifficultyChange.OnRedDotRightVisibleCallback = new Func<int, bool>(this.OnRedDotRightVisible);
		}

		// Token: 0x060318E7 RID: 202983 RVA: 0x00B7DDFE File Offset: 0x00B7BFFE
		public void InitSelectDifficulty(ETrapDefenseDifficultyLevel difficulty)
		{
			this.CurSelectDifficulty = difficulty;
		}

		// Token: 0x060318E8 RID: 202984 RVA: 0x00B7DE08 File Offset: 0x00B7C008
		public override void UpdateModeData()
		{
			List<ITrapDefenseDifficultyLevelInfo> difficultyTypeList = this.ModeData.GetDifficultyTypeList();
			int selectIndex = difficultyTypeList.FindIndex((ITrapDefenseDifficultyLevelInfo info) => info.DifficultyLevel == this.CurSelectDifficulty);
			this.DifficultyTypeList = difficultyTypeList.ToArray();
			this.PanelDifficultyChange.UpdateDataList(difficultyTypeList.ToArray(), selectIndex);
		}

		// Token: 0x060318E9 RID: 202985 RVA: 0x00B7DE54 File Offset: 0x00B7C054
		public void OnSelectDifficulty(ITrapDefenseDifficultyLevelInfo info)
		{
			this.CurSelectDifficulty = info.DifficultyLevel;
			List<TrapDefenseLevelData> levelDataListByDifficulty = this.ModeData.GetLevelDataListByDifficulty(info.DifficultyLevel);
			base.UpdateLevelDataList(levelDataListByDifficulty.ToArray());
		}

		// Token: 0x060318EA RID: 202986 RVA: 0x00B7DE8C File Offset: 0x00B7C08C
		public bool OnRedDotLeftVisible(int index)
		{
			ETrapDefenseDifficultyLevel difficultyLevel = this.DifficultyTypeList[index].DifficultyLevel;
			foreach (TrapDefenseLevelData data in this.ModeData.GetLevelDataListByDifficulty(difficultyLevel))
			{
				if (this.ModeData.GetLevelReachOpenTimeRedDotState(data))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060318EB RID: 202987 RVA: 0x00B7DF04 File Offset: 0x00B7C104
		public bool OnRedDotRightVisible(int index)
		{
			ETrapDefenseDifficultyLevel difficultyLevel = this.DifficultyTypeList[index].DifficultyLevel;
			foreach (TrapDefenseLevelData data in this.ModeData.GetLevelDataListByDifficulty(difficultyLevel))
			{
				if (this.ModeData.GetLevelReachOpenTimeRedDotState(data))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0401A7B3 RID: 108467
		public ETrapDefenseDifficultyLevel CurSelectDifficulty = ETrapDefenseDifficultyLevel.Normal;

		// Token: 0x0401A7B4 RID: 108468
		public ITrapDefenseDifficultyLevelInfo[] DifficultyTypeList;
	}
}
