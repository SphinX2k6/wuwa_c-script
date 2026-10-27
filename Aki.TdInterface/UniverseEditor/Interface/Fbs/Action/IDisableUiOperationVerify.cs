using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F9 RID: 26105
	public static class IDisableUiOperationVerify
	{
		// Token: 0x0602D514 RID: 185620 RVA: 0x00635EB2 File Offset: 0x006340B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
