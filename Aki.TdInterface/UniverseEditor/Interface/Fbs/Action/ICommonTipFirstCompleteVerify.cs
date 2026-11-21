using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B05 RID: 27397
	public static class ICommonTipFirstCompleteVerify
	{
		// Token: 0x0602F1A7 RID: 192935 RVA: 0x0066C9F7 File Offset: 0x0066ABF7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
