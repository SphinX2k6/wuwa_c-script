using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BAF RID: 15279
	public static class IShowTimelineBuffVerify
	{
		// Token: 0x06014F2C RID: 85804 RVA: 0x00309AAB File Offset: 0x00307CAB
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
