using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F88 RID: 20360
	public static class ICheckJigsawTypeVerify
	{
		// Token: 0x0601FB64 RID: 129892 RVA: 0x0046872E File Offset: 0x0046692E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
