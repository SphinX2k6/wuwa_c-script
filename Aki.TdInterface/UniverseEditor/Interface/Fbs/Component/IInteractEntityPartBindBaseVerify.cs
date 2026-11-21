using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CB RID: 22987
	public static class IInteractEntityPartBindBaseVerify
	{
		// Token: 0x06025866 RID: 153702 RVA: 0x00525F0A File Offset: 0x0052410A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
