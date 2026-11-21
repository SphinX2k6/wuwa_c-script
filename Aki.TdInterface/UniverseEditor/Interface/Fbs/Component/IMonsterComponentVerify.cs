using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B12 RID: 23314
	public static class IMonsterComponentVerify
	{
		// Token: 0x06026543 RID: 156995 RVA: 0x00540368 File Offset: 0x0053E568
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IBossStateViewConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMonsterComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMonsterComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IMonsterPerformConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 16, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
					{
						short offsetId3 = 20;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMonsterComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IMonsterComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IMonsterNpcInteractionEnableConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyVectorOfData(tablePos, 22, 1UL, false))
						{
							short offsetId4 = 26;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMonsterComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IMonsterComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IMonsterCommunicationGroupConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyVectorOfData(tablePos, 28, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083F4 RID: 33780
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146AA RID: 83626
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146AB RID: 83627
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040146AC RID: 83628
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040146AD RID: 83629
			public static VerifyTableAction <3>__Verify;
		}
	}
}
