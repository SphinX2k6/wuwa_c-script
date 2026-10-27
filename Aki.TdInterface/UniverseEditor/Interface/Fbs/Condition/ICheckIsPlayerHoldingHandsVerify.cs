using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A98 RID: 19096
	public static class ICheckIsPlayerHoldingHandsVerify
	{
		// Token: 0x0601DF3D RID: 122685 RVA: 0x004349BE File Offset: 0x00432BBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
