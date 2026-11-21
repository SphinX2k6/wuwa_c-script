using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007563 RID: 30051
	public static class IQiuyuanQinggongExploration3Verify
	{
		// Token: 0x06034B20 RID: 215840 RVA: 0x00716522 File Offset: 0x00714722
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
