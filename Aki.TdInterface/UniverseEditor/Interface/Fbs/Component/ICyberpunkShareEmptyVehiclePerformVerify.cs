using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005065 RID: 20581
	public static class ICyberpunkShareEmptyVehiclePerformVerify
	{
		// Token: 0x06020FC8 RID: 135112 RVA: 0x004956F7 File Offset: 0x004938F7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
