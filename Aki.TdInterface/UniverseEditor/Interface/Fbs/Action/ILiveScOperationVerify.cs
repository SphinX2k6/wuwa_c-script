using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007120 RID: 28960
	public static class ILiveScOperationVerify
	{
		// Token: 0x060324F0 RID: 206064 RVA: 0x006CD57E File Offset: 0x006CB77E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
