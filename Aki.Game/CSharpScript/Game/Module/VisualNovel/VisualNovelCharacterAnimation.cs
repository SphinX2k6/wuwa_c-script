using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A8 RID: 14248
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct VisualNovelCharacterAnimation
	{
		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x06025102 RID: 151810 RVA: 0x00A76843 File Offset: 0x00A74A43
		public int AvgTalkerId { get; }

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x06025103 RID: 151811 RVA: 0x00A7684B File Offset: 0x00A74A4B
		public string Body { get; }

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x06025104 RID: 151812 RVA: 0x00A76853 File Offset: 0x00A74A53
		public string Mouth { get; }

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x06025105 RID: 151813 RVA: 0x00A7685B File Offset: 0x00A74A5B
		public string MouthOpenSmall { get; }

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x06025106 RID: 151814 RVA: 0x00A76863 File Offset: 0x00A74A63
		public string MouthOpenLarge { get; }

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x06025107 RID: 151815 RVA: 0x00A7686B File Offset: 0x00A74A6B
		public string Eye { get; }

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x06025108 RID: 151816 RVA: 0x00A76873 File Offset: 0x00A74A73
		public string Blink { get; }

		// Token: 0x06025109 RID: 151817 RVA: 0x00A7687B File Offset: 0x00A74A7B
		public VisualNovelCharacterAnimation(int avgTalkerId, string body, string mouth, string mouthOpenSmall, string mouthOpenLarge, string eye, string blink)
		{
			this.AvgTalkerId = avgTalkerId;
			this.Body = body;
			this.Mouth = mouth;
			this.MouthOpenSmall = mouthOpenSmall;
			this.MouthOpenLarge = mouthOpenLarge;
			this.Eye = eye;
			this.Blink = blink;
		}
	}
}
