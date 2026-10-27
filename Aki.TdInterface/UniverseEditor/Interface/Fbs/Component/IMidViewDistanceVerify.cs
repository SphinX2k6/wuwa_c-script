using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005553 RID: 21843
	public static class IMidViewDistanceVerify
	{
		// Token: 0x060241D0 RID: 147920 RVA: 0x004FD1FE File Offset: 0x004FB3FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
