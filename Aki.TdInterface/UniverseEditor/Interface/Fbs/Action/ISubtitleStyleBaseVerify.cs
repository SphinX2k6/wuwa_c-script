using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007225 RID: 29221
	public static class ISubtitleStyleBaseVerify
	{
		// Token: 0x06033D61 RID: 212321 RVA: 0x006F9B76 File Offset: 0x006F7D76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
