using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF3 RID: 28147
	public static class IFadeBackgroundFadeOutEffectScreenEffectVerify
	{
		// Token: 0x06030978 RID: 199032 RVA: 0x00698EF3 File Offset: 0x006970F3
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
