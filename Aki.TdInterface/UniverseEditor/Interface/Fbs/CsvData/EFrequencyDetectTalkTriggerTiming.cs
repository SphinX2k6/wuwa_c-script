using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D63 RID: 19811
	public enum EFrequencyDetectTalkTriggerTiming : byte
	{
		// Token: 0x0400D9A6 RID: 55718
		AiStartPaint,
		// Token: 0x0400D9A7 RID: 55719
		AiEndPaint,
		// Token: 0x0400D9A8 RID: 55720
		PlayerStartPaint,
		// Token: 0x0400D9A9 RID: 55721
		PlayerEndPaint,
		// Token: 0x0400D9AA RID: 55722
		PlayerOutOfRange,
		// Token: 0x0400D9AB RID: 55723
		PlayerPaintWrongAiLine,
		// Token: 0x0400D9AC RID: 55724
		PlayerIdleTimeout,
		// Token: 0x0400D9AD RID: 55725
		AllTrackPainted
	}
}
