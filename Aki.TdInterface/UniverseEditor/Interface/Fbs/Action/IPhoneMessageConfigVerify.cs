using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA7 RID: 27815
	public static class IPhoneMessageConfigVerify
	{
		// Token: 0x06031048 RID: 200776 RVA: 0x006A7444 File Offset: 0x006A5644
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
