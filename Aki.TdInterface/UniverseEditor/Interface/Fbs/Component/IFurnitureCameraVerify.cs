using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585E RID: 22622
	public static class IFurnitureCameraVerify
	{
		// Token: 0x06024A7E RID: 150142 RVA: 0x0050917C File Offset: 0x0050737C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFurnitureCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFurnitureCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFurnitureCameraVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFurnitureCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFurnitureCameraVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IFurnitureCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IBlendFunctionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008397 RID: 33687
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014600 RID: 83456
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014601 RID: 83457
			public static VerifyTableAction <1>__Verify;
		}
	}
}
