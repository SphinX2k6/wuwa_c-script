using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD3 RID: 28115
	public static class IPromptStyleDefaultVerify
	{
		// Token: 0x06031A92 RID: 203410 RVA: 0x006BA15E File Offset: 0x006B835E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
