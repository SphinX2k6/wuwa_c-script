using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF5 RID: 27893
	public static class IPlayerHandInHandInitiatorVerify
	{
		// Token: 0x060312F8 RID: 201464 RVA: 0x006AC446 File Offset: 0x006AA646
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
