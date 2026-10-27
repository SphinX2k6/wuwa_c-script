using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E1A RID: 15898
	public static class IFailedTeleportVerify
	{
		// Token: 0x06016428 RID: 91176 RVA: 0x00336938 File Offset: 0x00334B38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFailedTeleportVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFailedTeleportVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFailedTeleportVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFailedTeleportVerify.<>O.<1>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078D7 RID: 30935
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401317B RID: 78203
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401317C RID: 78204
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
