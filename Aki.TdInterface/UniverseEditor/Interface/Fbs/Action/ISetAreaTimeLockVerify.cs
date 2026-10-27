using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAA RID: 28586
	public static class ISetAreaTimeLockVerify
	{
		// Token: 0x0603285A RID: 206938 RVA: 0x006D17B0 File Offset: 0x006CF9B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetAreaTimeLockVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAreaTimeLockVerify.<>O.<0>__Verify = new VerifyTableAction(IFixedTimeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E2E RID: 32302
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139EC RID: 80364
			public static VerifyTableAction <0>__Verify;
		}
	}
}
