using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005110 RID: 20752
	public static class IEffectAreaModeVerify
	{
		// Token: 0x06021707 RID: 136967 RVA: 0x004A47F6 File Offset: 0x004A29F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
