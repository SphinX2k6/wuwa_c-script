using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x02006546 RID: 25926
	public class MatchThreeLevelDetailViewModel
	{
		// Token: 0x1700953A RID: 38202
		// (get) Token: 0x06040FCD RID: 266189 RVA: 0x00FBF960 File Offset: 0x00FBDB60
		public int CurrentLevelId
		{
			get
			{
				if (this.ChapterData.LevelIds.Count == 0)
				{
					return 0;
				}
				if (this.DifficultyIndex < 0 || this.DifficultyIndex >= this.ChapterData.LevelIds.Count)
				{
					return this.ChapterData.PrimaryLevelId;
				}
				return this.ChapterData.LevelIds[this.DifficultyIndex];
			}
		}

		// Token: 0x04021E1D RID: 138781
		[Nullable(1)]
		public MatchThreeChapterSelectData ChapterData;

		// Token: 0x04021E1E RID: 138782
		public int DifficultyIndex;

		// Token: 0x04021E1F RID: 138783
		public int SelectedRoleId;
	}
}
