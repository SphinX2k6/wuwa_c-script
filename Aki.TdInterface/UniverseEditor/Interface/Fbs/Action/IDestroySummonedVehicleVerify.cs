using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C13 RID: 27667
	public static class IDestroySummonedVehicleVerify
	{
		// Token: 0x0602F9E4 RID: 195044 RVA: 0x0067D1A3 File Offset: 0x0067B3A3
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
