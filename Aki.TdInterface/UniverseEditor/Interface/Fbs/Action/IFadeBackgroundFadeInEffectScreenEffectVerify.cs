using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE4 RID: 28132
	public static class IFadeBackgroundFadeInEffectScreenEffectVerify
	{
		// Token: 0x06030908 RID: 198920 RVA: 0x0069833F File Offset: 0x0069653F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
