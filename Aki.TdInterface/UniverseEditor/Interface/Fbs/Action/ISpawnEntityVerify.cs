using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007171 RID: 29041
	public static class ISpawnEntityVerify
	{
		// Token: 0x060337E6 RID: 210918 RVA: 0x006EFE68 File Offset: 0x006EE068
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpawnEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnEntityVerify.<>O.<0>__Verify = new VerifyTableAction(ITransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISpawnEntityVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISpawnEntityVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E6A RID: 32362
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A48 RID: 80456
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A49 RID: 80457
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
