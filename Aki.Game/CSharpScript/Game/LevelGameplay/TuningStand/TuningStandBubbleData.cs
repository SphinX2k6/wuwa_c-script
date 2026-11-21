using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B24 RID: 23332
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandBubbleData : ITuningStandBubbleData
	{
		// Token: 0x17006D51 RID: 27985
		// (get) Token: 0x0603963F RID: 235071 RVA: 0x0101A8D5 File Offset: 0x01018AD5
		// (set) Token: 0x06039640 RID: 235072 RVA: 0x0101A8DD File Offset: 0x01018ADD
		public float WaitTime { get; set; }

		// Token: 0x17006D52 RID: 27986
		// (get) Token: 0x06039641 RID: 235073 RVA: 0x0101A8E6 File Offset: 0x01018AE6
		// (set) Token: 0x06039642 RID: 235074 RVA: 0x0101A8EE File Offset: 0x01018AEE
		public string MainRoleTex { get; set; }

		// Token: 0x17006D53 RID: 27987
		// (get) Token: 0x06039643 RID: 235075 RVA: 0x0101A8F7 File Offset: 0x01018AF7
		// (set) Token: 0x06039644 RID: 235076 RVA: 0x0101A8FF File Offset: 0x01018AFF
		public string MainRoleTalk { get; set; }

		// Token: 0x17006D54 RID: 27988
		// (get) Token: 0x06039645 RID: 235077 RVA: 0x0101A908 File Offset: 0x01018B08
		// (set) Token: 0x06039646 RID: 235078 RVA: 0x0101A910 File Offset: 0x01018B10
		public string FloroTex { get; set; }

		// Token: 0x17006D55 RID: 27989
		// (get) Token: 0x06039647 RID: 235079 RVA: 0x0101A919 File Offset: 0x01018B19
		// (set) Token: 0x06039648 RID: 235080 RVA: 0x0101A921 File Offset: 0x01018B21
		public string FloroTalk { get; set; }
	}
}
