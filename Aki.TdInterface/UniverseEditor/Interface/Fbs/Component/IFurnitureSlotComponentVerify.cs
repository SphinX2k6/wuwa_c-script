using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E1 RID: 21217
	public static class IFurnitureSlotComponentVerify
	{
		// Token: 0x06022A32 RID: 141874 RVA: 0x004CD1B8 File Offset: 0x004CB3B8
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

		// Token: 0x02007B3B RID: 31547
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013580 RID: 79232
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013581 RID: 79233
			public static VerifyTableAction <1>__Verify;
		}
	}
}
