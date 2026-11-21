using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007296 RID: 29334
	public static class IMoveOperationTypeVerify
	{
		// Token: 0x060331E1 RID: 209377 RVA: 0x006E5C8A File Offset: 0x006E3E8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
