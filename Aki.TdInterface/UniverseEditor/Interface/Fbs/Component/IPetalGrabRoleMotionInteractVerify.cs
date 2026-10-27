using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005729 RID: 22313
	public static class IPetalGrabRoleMotionInteractVerify
	{
		// Token: 0x0602556D RID: 152941 RVA: 0x00526DB8 File Offset: 0x00524FB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPetalGrabRoleMotionInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPetalGrabRoleMotionInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPetalGrabRoleMotionInteractVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPetalGrabRoleMotionInteractVerify.<>O.<1>__Verify = new VerifyTableAction(IPetalGrabEventVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BD3 RID: 31699
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401368E RID: 79502
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401368F RID: 79503
			public static VerifyTableAction <1>__Verify;
		}
	}
}
