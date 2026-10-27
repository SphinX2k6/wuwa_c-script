using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D5 RID: 25557
	public static class IClientModifySelfTargetVerify
	{
		// Token: 0x0602C354 RID: 181076 RVA: 0x00611982 File Offset: 0x0060FB82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
