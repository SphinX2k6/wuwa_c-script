using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A1 RID: 24993
	public static class IWoodElementalMatchVerify
	{
		// Token: 0x0602A7A4 RID: 173988 RVA: 0x005CB362 File Offset: 0x005C9562
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
