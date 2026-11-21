using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DA RID: 23002
	public static class IInteractEntityPartPrefabOptionPointVerify
	{
		// Token: 0x060258E0 RID: 153824 RVA: 0x00526C6E File Offset: 0x00524E6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
