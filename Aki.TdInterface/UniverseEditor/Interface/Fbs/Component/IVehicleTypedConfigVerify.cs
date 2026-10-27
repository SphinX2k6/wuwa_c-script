using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2B RID: 23339
	public static class IVehicleTypedConfigVerify
	{
		// Token: 0x06027E3D RID: 163389 RVA: 0x0057C492 File Offset: 0x0057A692
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
