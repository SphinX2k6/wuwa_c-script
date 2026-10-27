using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005703 RID: 22275
	public static class IPatrolVerify
	{
		// Token: 0x060253DE RID: 152542 RVA: 0x005239B4 File Offset: 0x00521BB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolVerify.<>O.<0>__Verify = new VerifyTableAction(IPatrolActionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BCE RID: 31694
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013686 RID: 79494
			public static VerifyTableAction <0>__Verify;
		}
	}
}
