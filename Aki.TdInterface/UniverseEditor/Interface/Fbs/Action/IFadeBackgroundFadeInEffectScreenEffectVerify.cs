using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006764 RID: 26468
	public static class IFadeBackgroundFadeInEffectScreenEffectVerify
	{
		// Token: 0x0602E0C2 RID: 188610 RVA: 0x0064ABFB File Offset: 0x00648DFB
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
