using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF6 RID: 28150
	public static class IFadeBackgroundFadeOutEffectTypeBaseVerify
	{
		// Token: 0x0603098A RID: 199050 RVA: 0x00699076 File Offset: 0x00697276
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
