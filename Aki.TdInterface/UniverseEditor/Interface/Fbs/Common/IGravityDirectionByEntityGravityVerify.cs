using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF6 RID: 24054
	public static class IGravityDirectionByEntityGravityVerify
	{
		// Token: 0x060292CF RID: 168655 RVA: 0x005A64D0 File Offset: 0x005A46D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
