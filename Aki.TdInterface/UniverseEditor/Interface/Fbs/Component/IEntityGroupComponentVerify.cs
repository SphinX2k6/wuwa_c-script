using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200517C RID: 20860
	public static class IEntityGroupComponentVerify
	{
		// Token: 0x06021BAC RID: 138156 RVA: 0x004AE3BC File Offset: 0x004AC5BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityGroupComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityGroupComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateTriggerVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityGroupComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityGroupComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IFinishStateTriggerVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IEntityGroupComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IEntityGroupComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IFailureStateTriggerVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AFB RID: 31483
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401351C RID: 79132
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401351D RID: 79133
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401351E RID: 79134
			public static VerifyTableAction <2>__Verify;
		}
	}
}
