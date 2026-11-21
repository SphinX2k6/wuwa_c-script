using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054C3 RID: 21699
	public class MatchThreeChapterSelectData
	{
		// Token: 0x17006899 RID: 26777
		// (get) Token: 0x06035C8E RID: 220302 RVA: 0x00F068E0 File Offset: 0x00F04AE0
		public int NormalLevelId
		{
			get
			{
				if (this.LevelIds.Count <= 0)
				{
					return 0;
				}
				return this.LevelIds[0];
			}
		}

		// Token: 0x1700689A RID: 26778
		// (get) Token: 0x06035C8F RID: 220303 RVA: 0x00F068FE File Offset: 0x00F04AFE
		public int HardLevelId
		{
			get
			{
				if (this.LevelIds.Count <= 1)
				{
					return 0;
				}
				return this.LevelIds[1];
			}
		}

		// Token: 0x1700689B RID: 26779
		// (get) Token: 0x06035C90 RID: 220304 RVA: 0x00F0691C File Offset: 0x00F04B1C
		public int PrimaryLevelId
		{
			get
			{
				if (this.LevelIds.Count <= 0)
				{
					return 0;
				}
				return this.LevelIds[0];
			}
		}

		// Token: 0x0401C74B RID: 116555
		public int Chapter;

		// Token: 0x0401C74C RID: 116556
		public bool IsEndless;

		// Token: 0x0401C74D RID: 116557
		[Nullable(1)]
		public List<int> LevelIds = new List<int>();
	}
}
