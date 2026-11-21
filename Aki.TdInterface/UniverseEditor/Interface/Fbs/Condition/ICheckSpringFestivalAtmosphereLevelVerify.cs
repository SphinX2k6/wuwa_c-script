using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005012 RID: 20498
	public static class ICheckSpringFestivalAtmosphereLevelVerify
	{
		// Token: 0x0601FFFA RID: 131066 RVA: 0x00470CB0 File Offset: 0x0046EEB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
