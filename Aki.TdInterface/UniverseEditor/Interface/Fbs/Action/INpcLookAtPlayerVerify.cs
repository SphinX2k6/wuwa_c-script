using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007333 RID: 29491
	public static class INpcLookAtPlayerVerify
	{
		// Token: 0x060336E5 RID: 210661 RVA: 0x006EEFB2 File Offset: 0x006ED1B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
