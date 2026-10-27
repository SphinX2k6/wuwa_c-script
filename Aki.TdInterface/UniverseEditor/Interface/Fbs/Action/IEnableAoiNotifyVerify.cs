using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006650 RID: 26192
	public static class IEnableAoiNotifyVerify
	{
		// Token: 0x0602D7F4 RID: 186356 RVA: 0x0063B16E File Offset: 0x0063936E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
