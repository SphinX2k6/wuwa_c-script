using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200781D RID: 30749
	public static class ISetPlayerOperationRestrictionVerify
	{
		// Token: 0x060360C1 RID: 221377 RVA: 0x0073D48E File Offset: 0x0073B68E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
