using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEE RID: 23278
	public static class IModelComponentVerify
	{
		// Token: 0x060263F3 RID: 156659 RVA: 0x0053DAE8 File Offset: 0x0053BCE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModelComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModelComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TModelTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					short offsetId = 24;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IModelComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IModelComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ICollisionChannelConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyVectorOfStrings(tablePos, 26, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083F2 RID: 33778
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146A7 RID: 83623
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040146A8 RID: 83624
			public static VerifyTableAction <1>__Verify;
		}
	}
}
