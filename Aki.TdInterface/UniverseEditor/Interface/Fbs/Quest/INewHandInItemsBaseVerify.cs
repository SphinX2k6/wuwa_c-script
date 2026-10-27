using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F52 RID: 16210
	public static class INewHandInItemsBaseVerify
	{
		// Token: 0x060170D1 RID: 94417 RVA: 0x00352CC2 File Offset: 0x00350EC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
