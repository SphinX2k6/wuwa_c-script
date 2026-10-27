using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006887 RID: 26759
	public static class IGetOffMotorcycleInteractVerify
	{
		// Token: 0x0602EAB8 RID: 191160 RVA: 0x0065D236 File Offset: 0x0065B436
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
