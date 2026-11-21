using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005864 RID: 22628
	public static class IFurnitureSlotComponentVerify
	{
		// Token: 0x06024ACC RID: 150220 RVA: 0x00509CE4 File Offset: 0x00507EE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFurnitureSlotComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFurnitureSlotComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFurnitureSlotVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFurnitureSlotComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFurnitureSlotComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IFurnitureCameraVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008399 RID: 33689
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014604 RID: 83460
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014605 RID: 83461
			public static VerifyTableAction <1>__Verify;
		}
	}
}
