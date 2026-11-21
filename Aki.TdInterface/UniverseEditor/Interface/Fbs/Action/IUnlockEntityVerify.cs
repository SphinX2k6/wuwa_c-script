using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD0 RID: 31952
	public static class IUnlockEntityVerify
	{
		// Token: 0x06039A35 RID: 236085 RVA: 0x007C6AF1 File Offset: 0x007C4CF1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
