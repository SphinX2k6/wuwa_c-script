using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AF RID: 26543
	public static class IFinishTalkVerify
	{
		// Token: 0x0602E2FD RID: 189181 RVA: 0x0064EB3A File Offset: 0x0064CD3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
