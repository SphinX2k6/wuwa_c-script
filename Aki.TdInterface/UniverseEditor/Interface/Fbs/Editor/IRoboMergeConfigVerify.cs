using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A3 RID: 18595
	public static class IRoboMergeConfigVerify
	{
		// Token: 0x0601D05F RID: 118879 RVA: 0x004196E5 File Offset: 0x004178E5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
