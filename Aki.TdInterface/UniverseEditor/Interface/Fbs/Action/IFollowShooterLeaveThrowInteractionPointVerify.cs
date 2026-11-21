using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDA RID: 28378
	public static class IFollowShooterLeaveThrowInteractionPointVerify
	{
		// Token: 0x06031196 RID: 201110 RVA: 0x006A8306 File Offset: 0x006A6506
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
