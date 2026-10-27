using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052DE RID: 21214
	public static class IFurnitureSlotVerify
	{
		// Token: 0x06022A0E RID: 141838 RVA: 0x004CCC5C File Offset: 0x004CAE5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFurnitureSlotVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFurnitureSlotVerify.<>O.<0>__Verify = new VerifyTableAction(IFurnitureCameraVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFurnitureSlotVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFurnitureSlotVerify.<>O.<1>__Verify = new VerifyTableAction(ISlotShapeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B3A RID: 31546
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401357E RID: 79230
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401357F RID: 79231
			public static VerifyTableAction <1>__Verify;
		}
	}
}
