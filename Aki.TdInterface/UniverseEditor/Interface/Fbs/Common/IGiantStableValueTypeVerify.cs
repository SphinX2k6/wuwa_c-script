using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200641B RID: 25627
	public static class IGiantStableValueTypeVerify
	{
		// Token: 0x0602B8A7 RID: 178343 RVA: 0x005EDE46 File Offset: 0x005EC046
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
