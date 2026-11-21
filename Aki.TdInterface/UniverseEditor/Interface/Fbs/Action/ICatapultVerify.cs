using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006927 RID: 26919
	public static class ICatapultVerify
	{
		// Token: 0x0602E21D RID: 188957 RVA: 0x0064DB78 File Offset: 0x0064BD78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICatapultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICatapultVerify.<>O.<0>__Verify = new VerifyTableAction(ICatapultParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICatapultVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICatapultVerify.<>O.<1>__Verify = new VerifyUnionAction(TCommonTargetVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200857B RID: 34171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014913 RID: 84243
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014914 RID: 84244
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
