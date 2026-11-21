using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3E RID: 27454
	public static class IControlElementalBoxTypeBaseVerify
	{
		// Token: 0x0602F3EB RID: 193515 RVA: 0x006735AE File Offset: 0x006717AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
