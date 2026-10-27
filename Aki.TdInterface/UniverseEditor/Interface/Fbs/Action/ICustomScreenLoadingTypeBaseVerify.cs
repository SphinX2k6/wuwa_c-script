using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006506 RID: 25862
	public static class ICustomScreenLoadingTypeBaseVerify
	{
		// Token: 0x0602CDD4 RID: 183764 RVA: 0x00629A5A File Offset: 0x00627C5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
