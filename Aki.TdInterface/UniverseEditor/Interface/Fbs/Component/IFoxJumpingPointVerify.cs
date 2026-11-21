using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582B RID: 22571
	public static class IFoxJumpingPointVerify
	{
		// Token: 0x0602488C RID: 149644 RVA: 0x00504EB8 File Offset: 0x005030B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpingPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFoxJumpingPointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFoxJumpingPointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IFoxJumpingPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFoxJumpingPointVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IFoxJumpingPointVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200838E RID: 33678
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145F1 RID: 83441
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145F2 RID: 83442
			public static VerifyTableAction <1>__Verify;
		}
	}
}
