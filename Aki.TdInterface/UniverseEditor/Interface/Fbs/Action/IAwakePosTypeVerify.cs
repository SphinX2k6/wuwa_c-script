using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006840 RID: 26688
	public static class IAwakePosTypeVerify
	{
		// Token: 0x0602D9DE RID: 186846 RVA: 0x0063DB9E File Offset: 0x0063BD9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
