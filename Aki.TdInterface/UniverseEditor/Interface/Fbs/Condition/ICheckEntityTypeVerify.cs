using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EDD RID: 20189
	public static class ICheckEntityTypeVerify
	{
		// Token: 0x0601F579 RID: 128377 RVA: 0x0045E076 File Offset: 0x0045C276
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
