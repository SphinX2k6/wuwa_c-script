using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200602B RID: 24619
	public static class ISystemModuleDataSyncDataVerify
	{
		// Token: 0x06029864 RID: 170084 RVA: 0x005AACAA File Offset: 0x005A8EAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
