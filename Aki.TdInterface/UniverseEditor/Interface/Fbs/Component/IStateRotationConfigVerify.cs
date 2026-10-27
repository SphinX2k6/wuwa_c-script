using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C1 RID: 22977
	public static class IStateRotationConfigVerify
	{
		// Token: 0x06026F18 RID: 159512 RVA: 0x0055B908 File Offset: 0x00559B08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStateRotationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStateRotationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IStartRotationConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStateRotationConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStateRotationConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IRotationConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IStateRotationConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IStateRotationConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IKeyRotatorConfigVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C3E RID: 31806
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401372C RID: 79660
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401372D RID: 79661
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401372E RID: 79662
			public static VerifyTableAction <2>__Verify;
		}
	}
}
