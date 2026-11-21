using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007746 RID: 30534
	public static class ISeqEventFireBulletVerify
	{
		// Token: 0x06035933 RID: 219443 RVA: 0x0072E31B File Offset: 0x0072C51B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
