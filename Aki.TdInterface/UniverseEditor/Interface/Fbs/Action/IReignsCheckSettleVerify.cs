using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AB RID: 30123
	public static class IReignsCheckSettleVerify
	{
		// Token: 0x06034D71 RID: 216433 RVA: 0x0071A742 File Offset: 0x00718942
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
