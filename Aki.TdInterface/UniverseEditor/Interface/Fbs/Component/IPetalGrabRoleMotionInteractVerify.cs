using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D30 RID: 23856
	public static class IPetalGrabRoleMotionInteractVerify
	{
		// Token: 0x06027A8D RID: 162445 RVA: 0x0056CEF4 File Offset: 0x0056B0F4
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
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						short typeIdVOffset = 16;
						short valueVOffset = 18;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IPetalGrabRoleMotionInteractVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IPetalGrabRoleMotionInteractVerify.<>O.<2>__Verify = new VerifyUnionAction(TSplineMovePatternVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008441 RID: 33857
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401472D RID: 83757
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401472E RID: 83758
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401472F RID: 83759
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
