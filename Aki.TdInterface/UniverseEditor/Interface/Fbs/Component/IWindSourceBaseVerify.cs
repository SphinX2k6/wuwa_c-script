using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006198 RID: 24984
	public static class IWindSourceBaseVerify
	{
		// Token: 0x0602A76C RID: 173932 RVA: 0x005CADD2 File Offset: 0x005C8FD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
