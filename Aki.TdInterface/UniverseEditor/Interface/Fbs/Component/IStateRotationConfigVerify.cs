using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FCE RID: 24526
	public static class IStateRotationConfigVerify
	{
		// Token: 0x0602948C RID: 169100 RVA: 0x005A2798 File Offset: 0x005A0998
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
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IStateRotationConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IStateRotationConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IAxisAngleMethodConfigVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020084AD RID: 33965
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147CE RID: 83918
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147CF RID: 83919
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040147D0 RID: 83920
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040147D1 RID: 83921
			public static VerifyTableAction <3>__Verify;
		}
	}
}
