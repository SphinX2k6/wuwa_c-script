using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D78 RID: 15736
	public static class ICheckTrapDefenseBdBuffQualityUpVerify
	{
		// Token: 0x06015C98 RID: 89240 RVA: 0x003241FA File Offset: 0x003223FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
