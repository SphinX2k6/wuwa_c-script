using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A73 RID: 27251
	public static class IClientSetSeasonStateConfigVerify
	{
		// Token: 0x0602EC1C RID: 191516 RVA: 0x0065F506 File Offset: 0x0065D706
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
