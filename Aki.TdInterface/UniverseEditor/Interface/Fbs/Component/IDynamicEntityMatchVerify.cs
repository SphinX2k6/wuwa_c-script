using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563F RID: 22079
	public static class IDynamicEntityMatchVerify
	{
		// Token: 0x06023458 RID: 144472 RVA: 0x004DA5C4 File Offset: 0x004D87C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicEntityMatchVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicEntityMatchVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityCategoryVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDynamicEntityMatchVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDynamicEntityMatchVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200833B RID: 33595
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014570 RID: 83312
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014571 RID: 83313
			public static VerifyTableAction <1>__Verify;
		}
	}
}
