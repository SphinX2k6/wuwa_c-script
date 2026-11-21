using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060C7 RID: 24775
	[NullableContext(1)]
	public interface IBrokenRockConfig
	{
		// Token: 0x1700706A RID: 28778
		// (get) Token: 0x0603B655 RID: 243285
		int Id { get; }

		// Token: 0x1700706B RID: 28779
		// (get) Token: 0x0603B656 RID: 243286
		int[] Rings { get; }

		// Token: 0x1700706C RID: 28780
		// (get) Token: 0x0603B657 RID: 243287
		int ScoreMax { get; }

		// Token: 0x1700706D RID: 28781
		// (get) Token: 0x0603B658 RID: 243288
		int ScoreUp { get; }

		// Token: 0x1700706E RID: 28782
		// (get) Token: 0x0603B659 RID: 243289
		int ScoreDown { get; }

		// Token: 0x1700706F RID: 28783
		// (get) Token: 0x0603B65A RID: 243290
		int GlobalTime { get; }

		// Token: 0x17007070 RID: 28784
		// (get) Token: 0x0603B65B RID: 243291
		int NormalSkill { get; }

		// Token: 0x17007071 RID: 28785
		// (get) Token: 0x0603B65C RID: 243292
		int FinishSkill { get; }

		// Token: 0x17007072 RID: 28786
		// (get) Token: 0x0603B65D RID: 243293
		string EntityUid { get; }
	}
}
