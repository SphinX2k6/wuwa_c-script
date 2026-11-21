using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557F RID: 21887
	public static class IConnectorRangeVerify
	{
		// Token: 0x06022C8A RID: 142474 RVA: 0x004CA5D8 File Offset: 0x004C87D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConnectorRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConnectorRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectorEffectConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConnectorRangeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConnectorRangeVerify.<>O.<1>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IConnectorRangeVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IConnectorRangeVerify.<>O.<1>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008321 RID: 33569
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401453E RID: 83262
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401453F RID: 83263
			public static VerifyTableAction <1>__Verify;
		}
	}
}
