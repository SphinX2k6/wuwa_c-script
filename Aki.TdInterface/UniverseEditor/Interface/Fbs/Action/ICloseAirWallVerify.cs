using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006414 RID: 25620
	public static class ICloseAirWallVerify
	{
		// Token: 0x0602C54C RID: 181580 RVA: 0x006158A2 File Offset: 0x00613AA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
