using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2B RID: 28459
	public static class IGetRewardByInteractVerify
	{
		// Token: 0x060313FF RID: 201727 RVA: 0x006AC3AE File Offset: 0x006AA5AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
