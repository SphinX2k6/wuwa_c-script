using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006971 RID: 26993
	public static class IInstrumentKeyConfigsVerify
	{
		// Token: 0x0602F21F RID: 193055 RVA: 0x0066BDDC File Offset: 0x00669FDC
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

		// Token: 0x02007D8B RID: 32139
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013914 RID: 80148
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013915 RID: 80149
			public static VerifyTableAction <1>__Verify;
		}
	}
}
