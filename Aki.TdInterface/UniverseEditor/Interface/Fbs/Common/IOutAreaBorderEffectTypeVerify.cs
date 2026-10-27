using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E1A RID: 24090
	public static class IOutAreaBorderEffectTypeVerify
	{
		// Token: 0x060293EF RID: 168943 RVA: 0x005A855E File Offset: 0x005A675E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
