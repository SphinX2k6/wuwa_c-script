using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005336 RID: 21302
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffIntroduceData : IMowingBuffIntroduceData
	{
		// Token: 0x17006700 RID: 26368
		// (get) Token: 0x06035058 RID: 217176 RVA: 0x00ED2601 File Offset: 0x00ED0801
		// (set) Token: 0x06035059 RID: 217177 RVA: 0x00ED2609 File Offset: 0x00ED0809
		public string BackgroundPath { get; set; }

		// Token: 0x17006701 RID: 26369
		// (get) Token: 0x0603505A RID: 217178 RVA: 0x00ED2612 File Offset: 0x00ED0812
		// (set) Token: 0x0603505B RID: 217179 RVA: 0x00ED261A File Offset: 0x00ED081A
		public string LevelTextId { get; set; }

		// Token: 0x17006702 RID: 26370
		// (get) Token: 0x0603505C RID: 217180 RVA: 0x00ED2623 File Offset: 0x00ED0823
		// (set) Token: 0x0603505D RID: 217181 RVA: 0x00ED262B File Offset: 0x00ED082B
		public string[] LevelTextArgs { get; set; }

		// Token: 0x17006703 RID: 26371
		// (get) Token: 0x0603505E RID: 217182 RVA: 0x00ED2634 File Offset: 0x00ED0834
		// (set) Token: 0x0603505F RID: 217183 RVA: 0x00ED263C File Offset: 0x00ED083C
		public string NameTextId { get; set; }

		// Token: 0x17006704 RID: 26372
		// (get) Token: 0x06035060 RID: 217184 RVA: 0x00ED2645 File Offset: 0x00ED0845
		// (set) Token: 0x06035061 RID: 217185 RVA: 0x00ED264D File Offset: 0x00ED084D
		public string TipsTextId { get; set; }

		// Token: 0x17006705 RID: 26373
		// (get) Token: 0x06035062 RID: 217186 RVA: 0x00ED2656 File Offset: 0x00ED0856
		// (set) Token: 0x06035063 RID: 217187 RVA: 0x00ED265E File Offset: 0x00ED085E
		public string[] TipsArgs { get; set; }

		// Token: 0x17006706 RID: 26374
		// (get) Token: 0x06035064 RID: 217188 RVA: 0x00ED2667 File Offset: 0x00ED0867
		// (set) Token: 0x06035065 RID: 217189 RVA: 0x00ED266F File Offset: 0x00ED086F
		public string IconPath { get; set; }

		// Token: 0x17006707 RID: 26375
		// (get) Token: 0x06035066 RID: 217190 RVA: 0x00ED2678 File Offset: 0x00ED0878
		// (set) Token: 0x06035067 RID: 217191 RVA: 0x00ED2680 File Offset: 0x00ED0880
		public string HexColor { get; set; }

		// Token: 0x17006708 RID: 26376
		// (get) Token: 0x06035068 RID: 217192 RVA: 0x00ED2689 File Offset: 0x00ED0889
		// (set) Token: 0x06035069 RID: 217193 RVA: 0x00ED2691 File Offset: 0x00ED0891
		public bool IsUnlock { get; set; }
	}
}
