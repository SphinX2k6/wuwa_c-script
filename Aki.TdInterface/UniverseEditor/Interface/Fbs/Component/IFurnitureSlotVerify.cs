using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005861 RID: 22625
	public static class IFurnitureSlotVerify
	{
		// Token: 0x06024AA8 RID: 150184 RVA: 0x00509788 File Offset: 0x00507988
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

		// Token: 0x02008398 RID: 33688
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014602 RID: 83458
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014603 RID: 83459
			public static VerifyTableAction <1>__Verify;
		}
	}
}
