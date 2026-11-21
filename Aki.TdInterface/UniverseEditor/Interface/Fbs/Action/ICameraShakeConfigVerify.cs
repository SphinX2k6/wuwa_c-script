using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006915 RID: 26901
	public static class ICameraShakeConfigVerify
	{
		// Token: 0x0602E181 RID: 188801 RVA: 0x0064C7F6 File Offset: 0x0064A9F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
