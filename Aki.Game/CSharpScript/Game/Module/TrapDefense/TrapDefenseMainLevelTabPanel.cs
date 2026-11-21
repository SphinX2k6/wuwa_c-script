using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A5F RID: 14943
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseMainLevelTabPanel : TrapDefenseLevelTabPanel<TrapDefenseLevelModeData>
	{
		// Token: 0x06026675 RID: 157301 RVA: 0x00AC1D33 File Offset: 0x00ABFF33
		public TrapDefenseMainLevelTabPanel()
		{
			this.ModeData = TrapDefenseModel.Instance.LevelModeData;
		}

		// Token: 0x06026676 RID: 157302 RVA: 0x00AC1D54 File Offset: 0x00ABFF54
		protected override void OnStart()
		{
			this.PanelDifficultyChange.SetActive(true);
			this.PanelDifficultyChange.OnSelectDifficultyCallback = new Action<ITrapDefenseDifficultyLevelInfo>(this.OnSelectDifficulty);
			this.PanelDifficultyChange.OnRedDotLeftVisibleCallback = new Func<int, bool>(this.OnRedDotLeftVisible);
			this.PanelDifficultyChange.OnRedDotRightVisibleCallback = new Func<int, bool>(this.OnRedDotRightVisible);
		}

		// Token: 0x06026677 RID: 157303 RVA: 0x00AC1DB2 File Offset: 0x00ABFFB2
		public void InitSelectDifficulty(ETrapDefenseDifficultyLevel difficulty)
		{
			this.CurSelectDifficulty = difficulty;
		}

		// Token: 0x06026678 RID: 157304 RVA: 0x00AC1DBC File Offset: 0x00ABFFBC
		public override void UpdateModeData()
		{
			List<ITrapDefenseDifficultyLevelInfo> difficultyTypeList = this.ModeData.GetDifficultyTypeList();
			int selectIndex = difficultyTypeList.FindIndex((ITrapDefenseDifficultyLevelInfo info) => info.DifficultyLevel == this.CurSelectDifficulty);
			this.DifficultyTypeList = difficultyTypeList.ToArray();
			this.PanelDifficultyChange.UpdateDataList(difficultyTypeList.ToArray(), selectIndex);
		}

		// Token: 0x06026679 RID: 157305 RVA: 0x00AC1E08 File Offset: 0x00AC0008
		public void OnSelectDifficulty(ITrapDefenseDifficultyLevelInfo info)
		{
			this.CurSelectDifficulty = info.DifficultyLevel;
			List<TrapDefenseLevelData> levelDataListByDifficulty = this.ModeData.GetLevelDataListByDifficulty(info.DifficultyLevel);
			base.UpdateLevelDataList(levelDataListByDifficulty.ToArray());
		}

		// Token: 0x0602667A RID: 157306 RVA: 0x00AC1E40 File Offset: 0x00AC0040
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

		// Token: 0x0602667B RID: 157307 RVA: 0x00AC1EB8 File Offset: 0x00AC00B8
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

		// Token: 0x04015105 RID: 86277
		public ETrapDefenseDifficultyLevel CurSelectDifficulty = ETrapDefenseDifficultyLevel.Normal;

		// Token: 0x04015106 RID: 86278
		public ITrapDefenseDifficultyLevelInfo[] DifficultyTypeList;
	}
}
