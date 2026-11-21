using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006825 RID: 26661
	public static class IAudioTypeBaseVerify
	{
		// Token: 0x0602D8F8 RID: 186616 RVA: 0x0063C2A2 File Offset: 0x0063A4A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
