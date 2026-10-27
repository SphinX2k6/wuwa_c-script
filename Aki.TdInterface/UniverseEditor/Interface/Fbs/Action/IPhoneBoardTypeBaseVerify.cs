using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9E RID: 27806
	public static class IPhoneBoardTypeBaseVerify
	{
		// Token: 0x06031010 RID: 200720 RVA: 0x006A6F52 File Offset: 0x006A5152
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
