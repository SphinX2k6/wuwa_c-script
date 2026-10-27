using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679D RID: 26525
	public static class IFaithJumpVerify
	{
		// Token: 0x0602E27D RID: 189053 RVA: 0x0064DD62 File Offset: 0x0064BF62
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
