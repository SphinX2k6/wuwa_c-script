using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052DB RID: 21211
	public static class IFurnitureCameraVerify
	{
		// Token: 0x060229E4 RID: 141796 RVA: 0x004CC650 File Offset: 0x004CA850
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

		// Token: 0x02007B39 RID: 31545
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401357C RID: 79228
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401357D RID: 79229
			public static VerifyTableAction <1>__Verify;
		}
	}
}
