using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E5 RID: 25829
	public static class ICreatePrefabVerify
	{
		// Token: 0x0602CCEE RID: 183534 RVA: 0x006284C8 File Offset: 0x006266C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICreatePrefabVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICreatePrefabVerify.<>O.<0>__Verify = new VerifyUnionAction(TPrefabConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICreatePrefabVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICreatePrefabVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D36 RID: 32054
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A5 RID: 80037
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040138A6 RID: 80038
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
