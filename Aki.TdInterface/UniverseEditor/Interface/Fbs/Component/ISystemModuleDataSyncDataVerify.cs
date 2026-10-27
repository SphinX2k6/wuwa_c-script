using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1E RID: 23070
	public static class ISystemModuleDataSyncDataVerify
	{
		// Token: 0x060272EC RID: 160492 RVA: 0x00563CE6 File Offset: 0x00561EE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
