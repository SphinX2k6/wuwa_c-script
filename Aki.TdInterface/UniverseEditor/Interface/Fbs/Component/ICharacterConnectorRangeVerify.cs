using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B6 RID: 21686
	public static class ICharacterConnectorRangeVerify
	{
		// Token: 0x0602229E RID: 139934 RVA: 0x004B575C File Offset: 0x004B395C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICharacterConnectorRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterConnectorRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectorEffectConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICharacterConnectorRangeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICharacterConnectorRangeVerify.<>O.<1>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICharacterConnectorRangeVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ICharacterConnectorRangeVerify.<>O.<1>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020082FF RID: 33535
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014508 RID: 83208
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014509 RID: 83209
			public static VerifyTableAction <1>__Verify;
		}
	}
}
