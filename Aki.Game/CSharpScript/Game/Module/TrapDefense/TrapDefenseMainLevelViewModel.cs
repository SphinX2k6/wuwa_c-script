using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A87 RID: 19079
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMainLevelViewModel
	{
		// Token: 0x0603174E RID: 202574 RVA: 0x00B76746 File Offset: 0x00B74946
		public static TrapDefenseMainLevelViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseMainLevelViewModel
			{
				Model = model
			};
		}

		// Token: 0x0603174F RID: 202575 RVA: 0x00B76754 File Offset: 0x00B74954
		private TrapDefenseMainLevelViewModel()
		{
		}

		// Token: 0x06031750 RID: 202576 RVA: 0x00B7675C File Offset: 0x00B7495C
		public void OnViewClose()
		{
		}

		// Token: 0x06031751 RID: 202577 RVA: 0x00B7675E File Offset: 0x00B7495E
		public void SetJumpDifficulty(ETrapDefenseDifficultyLevel? difficulty)
		{
			this.JumpDifficulty = difficulty;
		}

		// Token: 0x06031752 RID: 202578 RVA: 0x00B76768 File Offset: 0x00B74968
		public void SetJumpLevelData(int? id)
		{
			TrapDefenseLevelData trapDefenseLevelData;
			this.JumpLevelData = (this.Model.LevelDataFromIdMap.TryGetValue(id.GetValueOrDefault(), out trapDefenseLevelData) ? trapDefenseLevelData : null);
		}

		// Token: 0x06031753 RID: 202579 RVA: 0x00B7679A File Offset: 0x00B7499A
		public void SetIsInstance(bool isInstance)
		{
			this.IsInstance = isInstance;
		}

		// Token: 0x0401A725 RID: 108325
		public TrapDefenseModel Model;

		// Token: 0x0401A726 RID: 108326
		public ETrapDefenseDifficultyLevel? JumpDifficulty;

		// Token: 0x0401A727 RID: 108327
		[Nullable(2)]
		public TrapDefenseLevelData JumpLevelData;

		// Token: 0x0401A728 RID: 108328
		public bool IsInstance;
	}
}
