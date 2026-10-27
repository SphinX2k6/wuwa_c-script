using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005397 RID: 21399
	public static class IHitLogicChangeLockStateVerify
	{
		// Token: 0x060230B9 RID: 143545 RVA: 0x004DA38A File Offset: 0x004D858A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
