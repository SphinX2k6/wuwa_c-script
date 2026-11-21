using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006436 RID: 25654
	public static class IGravityDirectionSelfRotationVerify
	{
		// Token: 0x0602B96B RID: 178539 RVA: 0x005EF386 File Offset: 0x005ED586
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
