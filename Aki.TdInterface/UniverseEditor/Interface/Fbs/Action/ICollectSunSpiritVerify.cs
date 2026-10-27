using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006456 RID: 25686
	public static class ICollectSunSpiritVerify
	{
		// Token: 0x0602C734 RID: 182068 RVA: 0x00618BEE File Offset: 0x00616DEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
