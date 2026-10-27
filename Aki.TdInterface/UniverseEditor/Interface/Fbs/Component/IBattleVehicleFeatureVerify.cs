using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F00 RID: 20224
	public static class IBattleVehicleFeatureVerify
	{
		// Token: 0x0601FF31 RID: 130865 RVA: 0x004724C2 File Offset: 0x004706C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
