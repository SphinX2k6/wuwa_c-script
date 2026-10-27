using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006773 RID: 26483
	public static class IFadeBackgroundFadeOutEffectScreenEffectVerify
	{
		// Token: 0x0602E132 RID: 188722 RVA: 0x0064B7AF File Offset: 0x006499AF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
