using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200782C RID: 30764
	public static class ISetRegionConfigVerify
	{
		// Token: 0x060361A8 RID: 221608 RVA: 0x0073FB62 File Offset: 0x0073DD62
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
