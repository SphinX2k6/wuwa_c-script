using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A8 RID: 26792
	public static class IGroupAiCommunicateModeVerify
	{
		// Token: 0x0602EBB7 RID: 191415 RVA: 0x0065ECD2 File Offset: 0x0065CED2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
