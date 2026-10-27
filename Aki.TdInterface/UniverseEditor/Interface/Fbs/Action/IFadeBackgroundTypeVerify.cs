using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006782 RID: 26498
	public static class IFadeBackgroundTypeVerify
	{
		// Token: 0x0602E1A2 RID: 188834 RVA: 0x0064C466 File Offset: 0x0064A666
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
