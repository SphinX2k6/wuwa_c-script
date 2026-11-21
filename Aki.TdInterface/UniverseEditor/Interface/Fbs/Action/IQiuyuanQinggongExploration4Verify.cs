using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007566 RID: 30054
	public static class IQiuyuanQinggongExploration4Verify
	{
		// Token: 0x06034B32 RID: 215858 RVA: 0x0071669A File Offset: 0x0071489A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
