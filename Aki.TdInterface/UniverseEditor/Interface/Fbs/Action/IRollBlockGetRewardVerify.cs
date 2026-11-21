using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007689 RID: 30345
	public static class IRollBlockGetRewardVerify
	{
		// Token: 0x060353B6 RID: 218038 RVA: 0x00724AF2 File Offset: 0x00722CF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
