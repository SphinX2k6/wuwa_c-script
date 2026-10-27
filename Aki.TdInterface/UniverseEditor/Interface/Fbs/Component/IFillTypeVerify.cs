using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005251 RID: 21073
	public static class IFillTypeVerify
	{
		// Token: 0x0602247A RID: 140410 RVA: 0x004C0EC2 File Offset: 0x004BF0C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
