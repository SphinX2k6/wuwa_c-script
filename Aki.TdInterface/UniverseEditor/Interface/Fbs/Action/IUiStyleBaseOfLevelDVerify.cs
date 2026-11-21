using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA3 RID: 31907
	public static class IUiStyleBaseOfLevelDVerify
	{
		// Token: 0x060398E8 RID: 235752 RVA: 0x007C484A File Offset: 0x007C2A4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
