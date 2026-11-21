using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F31 RID: 28465
	public static class IGiantToggleModelVerify
	{
		// Token: 0x06031423 RID: 201763 RVA: 0x006AC692 File Offset: 0x006AA892
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
