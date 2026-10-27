using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005056 RID: 20566
	public static class ICustomBulletLogicVerify
	{
		// Token: 0x06020F52 RID: 134994 RVA: 0x00494ADA File Offset: 0x00492CDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
