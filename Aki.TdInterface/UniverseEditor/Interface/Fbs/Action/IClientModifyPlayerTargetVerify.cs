using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D2 RID: 25554
	public static class IClientModifyPlayerTargetVerify
	{
		// Token: 0x0602C342 RID: 181058 RVA: 0x0061180A File Offset: 0x0060FA0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
