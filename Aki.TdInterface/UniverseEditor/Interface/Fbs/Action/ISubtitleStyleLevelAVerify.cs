using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722B RID: 29227
	public static class ISubtitleStyleLevelAVerify
	{
		// Token: 0x06033D81 RID: 212353 RVA: 0x006F9E36 File Offset: 0x006F8036
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
