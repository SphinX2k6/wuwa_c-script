using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF9 RID: 24057
	public static class IGravityDirectionSelfRotationVerify
	{
		// Token: 0x060292E1 RID: 168673 RVA: 0x005A6656 File Offset: 0x005A4856
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
