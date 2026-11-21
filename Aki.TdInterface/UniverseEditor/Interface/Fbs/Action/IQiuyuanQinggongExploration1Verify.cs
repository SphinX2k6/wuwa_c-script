using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755D RID: 30045
	public static class IQiuyuanQinggongExploration1Verify
	{
		// Token: 0x06034AFC RID: 215804 RVA: 0x00716232 File Offset: 0x00714432
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
