using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x02006545 RID: 25925
	public class MatchThreeChapterSelectData
	{
		// Token: 0x17009537 RID: 38199
		// (get) Token: 0x06040FC9 RID: 266185 RVA: 0x00FBF8F0 File Offset: 0x00FBDAF0
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

		// Token: 0x17009538 RID: 38200
		// (get) Token: 0x06040FCA RID: 266186 RVA: 0x00FBF90E File Offset: 0x00FBDB0E
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

		// Token: 0x17009539 RID: 38201
		// (get) Token: 0x06040FCB RID: 266187 RVA: 0x00FBF92C File Offset: 0x00FBDB2C
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

		// Token: 0x04021E1A RID: 138778
		public int Chapter;

		// Token: 0x04021E1B RID: 138779
		public bool IsEndless;

		// Token: 0x04021E1C RID: 138780
		[Nullable(1)]
		public List<int> LevelIds = new List<int>();
	}
}
