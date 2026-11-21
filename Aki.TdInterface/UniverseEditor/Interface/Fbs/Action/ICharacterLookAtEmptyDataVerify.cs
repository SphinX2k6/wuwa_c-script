using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B6 RID: 27062
	public static class ICharacterLookAtEmptyDataVerify
	{
		// Token: 0x0602E6C1 RID: 190145 RVA: 0x00655B92 File Offset: 0x00653D92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
