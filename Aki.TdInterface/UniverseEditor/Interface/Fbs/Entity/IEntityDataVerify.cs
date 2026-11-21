using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C0C RID: 19468
	public static class IEntityDataVerify
	{
		// Token: 0x0601DC89 RID: 121993 RVA: 0x0042D840 File Offset: 0x0042BA40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityDataVerify.<>O.<0>__Verify = new VerifyTableAction(TComponentsDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false))
				{
					short offsetId2 = 34;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityDataVerify.<>O.<1>__Verify = new VerifyTableAction(ITransformVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 40, 2UL, 2UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200823F RID: 33343
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401440A RID: 82954
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401440B RID: 82955
			public static VerifyTableAction <1>__Verify;
		}
	}
}
