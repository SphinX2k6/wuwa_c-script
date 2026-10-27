using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D69 RID: 15721
	public static class ICheckSpringFestivalGameplayTypeVerify
	{
		// Token: 0x06015C16 RID: 89110 RVA: 0x003232BA File Offset: 0x003214BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
