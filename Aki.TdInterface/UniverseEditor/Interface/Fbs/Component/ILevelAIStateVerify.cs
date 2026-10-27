using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DE RID: 21726
	public static class ILevelAIStateVerify
	{
		// Token: 0x06023D3D RID: 146749 RVA: 0x004F4024 File Offset: 0x004F2224
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelAIStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelAIStateVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ILevelAIStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelAIStateVerify.<>O.<1>__Verify = new VerifyUnionAction(TLevelAIBehaviourVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B7F RID: 31615
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135FE RID: 79358
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135FF RID: 79359
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
