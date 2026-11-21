using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200503C RID: 20540
	public static class ICheckTargetTypeVerify
	{
		// Token: 0x06020188 RID: 131464 RVA: 0x00473E2E File Offset: 0x0047202E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
