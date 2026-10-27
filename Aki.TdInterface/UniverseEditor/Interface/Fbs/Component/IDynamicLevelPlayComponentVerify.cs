using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E6 RID: 20710
	public static class IDynamicLevelPlayComponentVerify
	{
		// Token: 0x0602156C RID: 136556 RVA: 0x004A1310 File Offset: 0x0049F510
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
