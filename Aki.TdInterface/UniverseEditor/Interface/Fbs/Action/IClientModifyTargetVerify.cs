using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D8 RID: 25560
	public static class IClientModifyTargetVerify
	{
		// Token: 0x0602C366 RID: 181094 RVA: 0x00611AFA File Offset: 0x0060FCFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
