using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E35 RID: 24117
	public static class IRefreshOnDeathVerify
	{
		// Token: 0x060284A4 RID: 165028 RVA: 0x00582482 File Offset: 0x00580682
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
