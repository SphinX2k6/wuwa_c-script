using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A2F RID: 14895
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMainLevelViewModel
	{
		// Token: 0x060264DE RID: 156894 RVA: 0x00ABA6FA File Offset: 0x00AB88FA
		public static TrapDefenseMainLevelViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseMainLevelViewModel
			{
				Model = model
			};
		}

		// Token: 0x060264DF RID: 156895 RVA: 0x00ABA708 File Offset: 0x00AB8908
		private TrapDefenseMainLevelViewModel()
		{
		}

		// Token: 0x060264E0 RID: 156896 RVA: 0x00ABA710 File Offset: 0x00AB8910
		public void OnViewClose()
		{
		}

		// Token: 0x060264E1 RID: 156897 RVA: 0x00ABA712 File Offset: 0x00AB8912
		public void SetJumpDifficulty(ETrapDefenseDifficultyLevel? difficulty)
		{
			this.JumpDifficulty = difficulty;
		}

		// Token: 0x060264E2 RID: 156898 RVA: 0x00ABA71C File Offset: 0x00AB891C
		public void SetJumpLevelData(int? id)
		{
			TrapDefenseLevelData trapDefenseLevelData;
			this.JumpLevelData = (this.Model.LevelDataFromIdMap.TryGetValue(id.GetValueOrDefault(), out trapDefenseLevelData) ? trapDefenseLevelData : null);
		}

		// Token: 0x060264E3 RID: 156899 RVA: 0x00ABA74E File Offset: 0x00AB894E
		public void SetIsInstance(bool isInstance)
		{
			this.IsInstance = isInstance;
		}

		// Token: 0x04015077 RID: 86135
		public TrapDefenseModel Model;

		// Token: 0x04015078 RID: 86136
		public ETrapDefenseDifficultyLevel? JumpDifficulty;

		// Token: 0x04015079 RID: 86137
		[Nullable(2)]
		public TrapDefenseLevelData JumpLevelData;

		// Token: 0x0401507A RID: 86138
		public bool IsInstance;
	}
}
