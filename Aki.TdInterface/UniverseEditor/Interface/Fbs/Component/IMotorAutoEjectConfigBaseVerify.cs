using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A7 RID: 21927
	public static class IMotorAutoEjectConfigBaseVerify
	{
		// Token: 0x060244CE RID: 148686 RVA: 0x00502CEE File Offset: 0x00500EEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
