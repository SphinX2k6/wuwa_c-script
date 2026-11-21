using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006141 RID: 24897
	public static class IVehicleTypedConfigVerify
	{
		// Token: 0x0602A401 RID: 173057 RVA: 0x005C3EE6 File Offset: 0x005C20E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
