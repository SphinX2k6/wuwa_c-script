using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF3 RID: 23539
	public static class INpcSpecialMarkIgnoreCameraHideNpcVerify
	{
		// Token: 0x06026DF7 RID: 159223 RVA: 0x00552516 File Offset: 0x00550716
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
