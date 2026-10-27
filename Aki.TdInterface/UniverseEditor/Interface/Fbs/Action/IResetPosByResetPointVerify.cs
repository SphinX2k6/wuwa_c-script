using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA5 RID: 28325
	public static class IResetPosByResetPointVerify
	{
		// Token: 0x06032102 RID: 205058 RVA: 0x006C5336 File Offset: 0x006C3536
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
