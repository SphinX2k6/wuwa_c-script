using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006076 RID: 24694
	public static class IActionContextTypeVerify
	{
		// Token: 0x06029D1F RID: 171295 RVA: 0x005BCC8E File Offset: 0x005BAE8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
