using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755A RID: 30042
	public static class IQiuyuanQinggongEndVerify
	{
		// Token: 0x06034AEA RID: 215786 RVA: 0x007160BA File Offset: 0x007142BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
