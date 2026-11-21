using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060C9 RID: 24777
	[NullableContext(1)]
	public interface IBrokenRockRingConfig
	{
		// Token: 0x1700707C RID: 28796
		// (get) Token: 0x0603B671 RID: 243313
		// (set) Token: 0x0603B672 RID: 243314
		int Id { get; set; }

		// Token: 0x1700707D RID: 28797
		// (get) Token: 0x0603B673 RID: 243315
		// (set) Token: 0x0603B674 RID: 243316
		List<List<int>> InvalidBox { get; set; }

		// Token: 0x1700707E RID: 28798
		// (get) Token: 0x0603B675 RID: 243317
		// (set) Token: 0x0603B676 RID: 243318
		int[] RandomBox { get; set; }

		// Token: 0x1700707F RID: 28799
		// (get) Token: 0x0603B677 RID: 243319
		// (set) Token: 0x0603B678 RID: 243320
		int PerfectBox { get; set; }

		// Token: 0x17007080 RID: 28800
		// (get) Token: 0x0603B679 RID: 243321
		// (set) Token: 0x0603B67A RID: 243322
		Dictionary<int, int> BonusRate { get; set; }

		// Token: 0x17007081 RID: 28801
		// (get) Token: 0x0603B67B RID: 243323
		// (set) Token: 0x0603B67C RID: 243324
		int GoodScore { get; set; }

		// Token: 0x17007082 RID: 28802
		// (get) Token: 0x0603B67D RID: 243325
		// (set) Token: 0x0603B67E RID: 243326
		int PerfectScore { get; set; }

		// Token: 0x17007083 RID: 28803
		// (get) Token: 0x0603B67F RID: 243327
		// (set) Token: 0x0603B680 RID: 243328
		int BonusScore { get; set; }

		// Token: 0x17007084 RID: 28804
		// (get) Token: 0x0603B681 RID: 243329
		// (set) Token: 0x0603B682 RID: 243330
		Dictionary<int, int> Speed { get; set; }

		// Token: 0x17007085 RID: 28805
		// (get) Token: 0x0603B683 RID: 243331
		// (set) Token: 0x0603B684 RID: 243332
		int ColdTime { get; set; }

		// Token: 0x17007086 RID: 28806
		// (get) Token: 0x0603B685 RID: 243333
		// (set) Token: 0x0603B686 RID: 243334
		int MultiBoxGroup { get; set; }

		// Token: 0x17007087 RID: 28807
		// (get) Token: 0x0603B687 RID: 243335
		// (set) Token: 0x0603B688 RID: 243336
		int[] Offset { get; set; }

		// Token: 0x17007088 RID: 28808
		// (get) Token: 0x0603B689 RID: 243337
		// (set) Token: 0x0603B68A RID: 243338
		bool IsAnticlockwise { get; set; }
	}
}
