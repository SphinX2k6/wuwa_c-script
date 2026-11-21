using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749F RID: 29855
	public class IPlayLevelSequenceT
	{
		// Token: 0x1700DB55 RID: 56149
		// (get) Token: 0x06034464 RID: 214116 RVA: 0x0070A621 File Offset: 0x00708821
		// (set) Token: 0x06034465 RID: 214117 RVA: 0x0070A629 File Offset: 0x00708829
		public string LevelSequencePath { get; set; }

		// Token: 0x1700DB56 RID: 56150
		// (get) Token: 0x06034466 RID: 214118 RVA: 0x0070A632 File Offset: 0x00708832
		// (set) Token: 0x06034467 RID: 214119 RVA: 0x0070A63A File Offset: 0x0070883A
		public bool IsEnableCenterOffset { get; set; }

		// Token: 0x1700DB57 RID: 56151
		// (get) Token: 0x06034468 RID: 214120 RVA: 0x0070A643 File Offset: 0x00708843
		// (set) Token: 0x06034469 RID: 214121 RVA: 0x0070A64B File Offset: 0x0070884B
		public bool KeepUI { get; set; }

		// Token: 0x1700DB58 RID: 56152
		// (get) Token: 0x0603446A RID: 214122 RVA: 0x0070A654 File Offset: 0x00708854
		// (set) Token: 0x0603446B RID: 214123 RVA: 0x0070A65C File Offset: 0x0070885C
		public string Mark { get; set; }

		// Token: 0x1700DB59 RID: 56153
		// (get) Token: 0x0603446C RID: 214124 RVA: 0x0070A665 File Offset: 0x00708865
		// (set) Token: 0x0603446D RID: 214125 RVA: 0x0070A66D File Offset: 0x0070886D
		public TPlayMode PlayMode { get; set; }

		// Token: 0x1700DB5A RID: 56154
		// (get) Token: 0x0603446E RID: 214126 RVA: 0x0070A676 File Offset: 0x00708876
		// (set) Token: 0x0603446F RID: 214127 RVA: 0x0070A67E File Offset: 0x0070887E
		public ILoopRangeT LoopRange { get; set; }

		// Token: 0x1700DB5B RID: 56155
		// (get) Token: 0x06034470 RID: 214128 RVA: 0x0070A687 File Offset: 0x00708887
		// (set) Token: 0x06034471 RID: 214129 RVA: 0x0070A68F File Offset: 0x0070888F
		public TLevelSequenceTransitionUnion Intro { get; set; }

		// Token: 0x1700DB5C RID: 56156
		// (get) Token: 0x06034472 RID: 214130 RVA: 0x0070A698 File Offset: 0x00708898
		// (set) Token: 0x06034473 RID: 214131 RVA: 0x0070A6A0 File Offset: 0x007088A0
		public TLevelSequenceTransitionUnion Outro { get; set; }

		// Token: 0x1700DB5D RID: 56157
		// (get) Token: 0x06034474 RID: 214132 RVA: 0x0070A6A9 File Offset: 0x007088A9
		// (set) Token: 0x06034475 RID: 214133 RVA: 0x0070A6B1 File Offset: 0x007088B1
		public float Rate { get; set; }

		// Token: 0x1700DB5E RID: 56158
		// (get) Token: 0x06034476 RID: 214134 RVA: 0x0070A6BA File Offset: 0x007088BA
		// (set) Token: 0x06034477 RID: 214135 RVA: 0x0070A6C2 File Offset: 0x007088C2
		public IEaseDataT RateEase { get; set; }

		// Token: 0x1700DB5F RID: 56159
		// (get) Token: 0x06034478 RID: 214136 RVA: 0x0070A6CB File Offset: 0x007088CB
		// (set) Token: 0x06034479 RID: 214137 RVA: 0x0070A6D3 File Offset: 0x007088D3
		public bool IsPlayOnTeleport { get; set; }

		// Token: 0x1700DB60 RID: 56160
		// (get) Token: 0x0603447A RID: 214138 RVA: 0x0070A6DC File Offset: 0x007088DC
		// (set) Token: 0x0603447B RID: 214139 RVA: 0x0070A6E4 File Offset: 0x007088E4
		public bool IsCarryCharacter { get; set; }

		// Token: 0x1700DB61 RID: 56161
		// (get) Token: 0x0603447C RID: 214140 RVA: 0x0070A6ED File Offset: 0x007088ED
		// (set) Token: 0x0603447D RID: 214141 RVA: 0x0070A6F5 File Offset: 0x007088F5
		public IFloatingSubtitleLanguageDiffT PreprocessOperation { get; set; }

		// Token: 0x1700DB62 RID: 56162
		// (get) Token: 0x0603447E RID: 214142 RVA: 0x0070A6FE File Offset: 0x007088FE
		// (set) Token: 0x0603447F RID: 214143 RVA: 0x0070A706 File Offset: 0x00708906
		public byte NullMask { get; set; }

		// Token: 0x06034480 RID: 214144 RVA: 0x0070A710 File Offset: 0x00708910
		public IPlayLevelSequenceT()
		{
			this.LevelSequencePath = null;
			this.IsEnableCenterOffset = false;
			this.KeepUI = false;
			this.Mark = null;
			this.PlayMode = TPlayMode.direct;
			this.LoopRange = null;
			this.Intro = null;
			this.Outro = null;
			this.Rate = 0f;
			this.RateEase = null;
			this.IsPlayOnTeleport = false;
			this.IsCarryCharacter = false;
			this.PreprocessOperation = null;
			this.NullMask = 0;
		}
	}
}
