using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200649C RID: 25756
	public static class IUnlockAtlasSystemTypeV2Verify
	{
		// Token: 0x0602BC88 RID: 179336 RVA: 0x005F4BEA File Offset: 0x005F2DEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
