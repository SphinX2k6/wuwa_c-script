using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B45 RID: 23365
	public static class IMotorAutoEjectConfigBaseVerify
	{
		// Token: 0x060266DB RID: 157403 RVA: 0x00543266 File Offset: 0x00541466
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
