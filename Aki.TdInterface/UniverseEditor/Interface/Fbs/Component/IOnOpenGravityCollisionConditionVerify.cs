using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A6 RID: 22182
	public static class IOnOpenGravityCollisionConditionVerify
	{
		// Token: 0x0602505B RID: 151643 RVA: 0x0051CBA5 File Offset: 0x0051ADA5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
