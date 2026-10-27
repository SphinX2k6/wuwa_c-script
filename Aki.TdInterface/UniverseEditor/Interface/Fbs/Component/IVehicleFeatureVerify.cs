using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B10 RID: 23312
	public static class IVehicleFeatureVerify
	{
		// Token: 0x06027D47 RID: 163143 RVA: 0x0057A7F6 File Offset: 0x005789F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
