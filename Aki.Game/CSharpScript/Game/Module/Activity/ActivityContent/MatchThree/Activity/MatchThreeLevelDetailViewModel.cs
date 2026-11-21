using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054C4 RID: 21700
	public class MatchThreeLevelDetailViewModel
	{
		// Token: 0x1700689C RID: 26780
		// (get) Token: 0x06035C92 RID: 220306 RVA: 0x00F06950 File Offset: 0x00F04B50
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

		// Token: 0x0401C74E RID: 116558
		[Nullable(1)]
		public MatchThreeChapterSelectData ChapterData;

		// Token: 0x0401C74F RID: 116559
		public int DifficultyIndex;

		// Token: 0x0401C750 RID: 116560
		public int SelectedRoleId;
	}
}
