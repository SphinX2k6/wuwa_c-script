using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A07 RID: 27143
	public static class IClientEnableAllPlayerOperationVerify
	{
		// Token: 0x0602E920 RID: 190752 RVA: 0x0065A0F6 File Offset: 0x006582F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
