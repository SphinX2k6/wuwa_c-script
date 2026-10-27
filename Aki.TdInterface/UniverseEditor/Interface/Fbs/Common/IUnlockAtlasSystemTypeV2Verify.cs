using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E5C RID: 24156
	public static class IUnlockAtlasSystemTypeV2Verify
	{
		// Token: 0x060295EC RID: 169452 RVA: 0x005ABD42 File Offset: 0x005A9F42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
