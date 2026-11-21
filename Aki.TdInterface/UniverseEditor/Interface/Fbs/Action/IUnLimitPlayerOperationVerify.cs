using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CB5 RID: 31925
	public static class IUnLimitPlayerOperationVerify
	{
		// Token: 0x06039977 RID: 235895 RVA: 0x007C57AE File Offset: 0x007C39AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
