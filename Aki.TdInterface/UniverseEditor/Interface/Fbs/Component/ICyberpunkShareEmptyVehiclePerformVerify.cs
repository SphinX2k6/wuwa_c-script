using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C7 RID: 21959
	public static class ICyberpunkShareEmptyVehiclePerformVerify
	{
		// Token: 0x06022F02 RID: 143106 RVA: 0x004CF3AB File Offset: 0x004CD5AB
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
