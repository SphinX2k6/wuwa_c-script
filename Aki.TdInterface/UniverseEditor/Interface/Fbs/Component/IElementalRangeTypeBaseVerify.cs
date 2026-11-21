using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569F RID: 22175
	public static class IElementalRangeTypeBaseVerify
	{
		// Token: 0x060237F5 RID: 145397 RVA: 0x004E2016 File Offset: 0x004E0216
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
