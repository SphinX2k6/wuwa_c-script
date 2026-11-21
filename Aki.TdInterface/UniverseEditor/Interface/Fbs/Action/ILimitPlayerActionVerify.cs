using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C3 RID: 28867
	public static class ILimitPlayerActionVerify
	{
		// Token: 0x0603220E RID: 205326 RVA: 0x006C88E2 File Offset: 0x006C6AE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
