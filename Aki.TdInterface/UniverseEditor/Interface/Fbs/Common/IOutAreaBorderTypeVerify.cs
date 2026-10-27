using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E29 RID: 24105
	public static class IOutAreaBorderTypeVerify
	{
		// Token: 0x0602944D RID: 169037 RVA: 0x005A8F06 File Offset: 0x005A7106
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
