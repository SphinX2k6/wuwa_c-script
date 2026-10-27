using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007366 RID: 29542
	public static class ITargetVehicleVerify
	{
		// Token: 0x060359E7 RID: 219623 RVA: 0x0074D456 File Offset: 0x0074B656
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
