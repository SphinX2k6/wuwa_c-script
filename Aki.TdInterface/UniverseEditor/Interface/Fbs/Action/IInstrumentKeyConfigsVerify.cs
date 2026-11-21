using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007024 RID: 28708
	public static class IInstrumentKeyConfigsVerify
	{
		// Token: 0x06031BEF RID: 203759 RVA: 0x006BC2C4 File Offset: 0x006BA4C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInstrumentKeyConfigsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInstrumentKeyConfigsVerify.<>O.<0>__Verify = new VerifyTableAction(IInstrumentKeyAttributeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IInstrumentKeyConfigsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInstrumentKeyConfigsVerify.<>O.<1>__Verify = new VerifyTableAction(IInstrumentBoardSizeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008606 RID: 34310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149C5 RID: 84421
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149C6 RID: 84422
			public static VerifyTableAction <1>__Verify;
		}
	}
}
