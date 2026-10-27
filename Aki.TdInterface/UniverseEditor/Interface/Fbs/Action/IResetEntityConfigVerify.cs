using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E81 RID: 28289
	public static class IResetEntityConfigVerify
	{
		// Token: 0x06031FFA RID: 204794 RVA: 0x006C3696 File Offset: 0x006C1896
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
