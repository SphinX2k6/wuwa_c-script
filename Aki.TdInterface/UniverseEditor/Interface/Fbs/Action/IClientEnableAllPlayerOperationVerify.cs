using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006396 RID: 25494
	public static class IClientEnableAllPlayerOperationVerify
	{
		// Token: 0x0602C1BE RID: 180670 RVA: 0x0060F0BE File Offset: 0x0060D2BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
