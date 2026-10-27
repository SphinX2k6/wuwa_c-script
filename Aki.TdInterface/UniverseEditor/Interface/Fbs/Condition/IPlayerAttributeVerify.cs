using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C84 RID: 19588
	public static class IPlayerAttributeVerify
	{
		// Token: 0x0601F11C RID: 127260 RVA: 0x00457A05 File Offset: 0x00455C05
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
