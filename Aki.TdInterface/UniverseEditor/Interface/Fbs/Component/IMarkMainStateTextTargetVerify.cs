using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005520 RID: 21792
	public static class IMarkMainStateTextTargetVerify
	{
		// Token: 0x06023FE2 RID: 147426 RVA: 0x004F9471 File Offset: 0x004F7671
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
