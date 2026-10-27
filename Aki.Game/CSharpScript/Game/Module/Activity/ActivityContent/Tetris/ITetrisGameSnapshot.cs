using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FF1 RID: 24561
	[NullableContext(1)]
	public interface ITetrisGameSnapshot
	{
		// Token: 0x17009059 RID: 36953
		// (get) Token: 0x0603E3AB RID: 254891
		// (set) Token: 0x0603E3AC RID: 254892
		TetrisCellData[][] BoardCells { get; set; }

		// Token: 0x1700905A RID: 36954
		// (get) Token: 0x0603E3AD RID: 254893
		// (set) Token: 0x0603E3AE RID: 254894
		[Nullable(new byte[]
		{
			1,
			2
		})]
		List<BlockInstance> HandShapes { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x1700905B RID: 36955
		// (get) Token: 0x0603E3AF RID: 254895
		// (set) Token: 0x0603E3B0 RID: 254896
		ITetrisScoreSnapshot ScoreSnapshot { get; set; }

		// Token: 0x1700905C RID: 36956
		// (get) Token: 0x0603E3B1 RID: 254897
		// (set) Token: 0x0603E3B2 RID: 254898
		ITetrisGemSnapshot GemSnapshot { get; set; }

		// Token: 0x1700905D RID: 36957
		// (get) Token: 0x0603E3B3 RID: 254899
		// (set) Token: 0x0603E3B4 RID: 254900
		int CurrentRoundIndex { get; set; }

		// Token: 0x1700905E RID: 36958
		// (get) Token: 0x0603E3B5 RID: 254901
		// (set) Token: 0x0603E3B6 RID: 254902
		int CurrentStageIndex { get; set; }

		// Token: 0x1700905F RID: 36959
		// (get) Token: 0x0603E3B7 RID: 254903
		// (set) Token: 0x0603E3B8 RID: 254904
		int PlaceCount { get; set; }
	}
}
