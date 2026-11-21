using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007638 RID: 30264
	public static class IRestoreAiBehaviorTreeVerify
	{
		// Token: 0x060351B6 RID: 217526 RVA: 0x00721BC5 File Offset: 0x0071FDC5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
