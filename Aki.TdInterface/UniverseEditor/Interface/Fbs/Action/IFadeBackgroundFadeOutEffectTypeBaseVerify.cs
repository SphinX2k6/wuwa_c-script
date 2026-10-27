using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006776 RID: 26486
	public static class IFadeBackgroundFadeOutEffectTypeBaseVerify
	{
		// Token: 0x0602E144 RID: 188740 RVA: 0x0064B932 File Offset: 0x00649B32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
