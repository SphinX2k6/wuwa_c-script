using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE7 RID: 28135
	public static class IFadeBackgroundFadeInEffectTypeBaseVerify
	{
		// Token: 0x0603091A RID: 198938 RVA: 0x006984C2 File Offset: 0x006966C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
