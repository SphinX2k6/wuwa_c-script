using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C9 RID: 29641
	public static class ITetrisGameCompleteVerify
	{
		// Token: 0x06035D5A RID: 220506 RVA: 0x007540A2 File Offset: 0x007522A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
