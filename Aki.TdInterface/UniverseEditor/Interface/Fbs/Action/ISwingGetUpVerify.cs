using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A21 RID: 31265
	public static class ISwingGetUpVerify
	{
		// Token: 0x0603715F RID: 225631 RVA: 0x0075C5E2 File Offset: 0x0075A7E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
