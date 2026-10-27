using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE5 RID: 28133
	public static class IQiuyuanQinggongExploration2Verify
	{
		// Token: 0x06031B12 RID: 203538 RVA: 0x006BACC2 File Offset: 0x006B8EC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
