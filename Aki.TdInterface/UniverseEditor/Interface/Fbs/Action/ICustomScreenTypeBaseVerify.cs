using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006512 RID: 25874
	public static class ICustomScreenTypeBaseVerify
	{
		// Token: 0x0602CE24 RID: 183844 RVA: 0x0062A18A File Offset: 0x0062838A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
