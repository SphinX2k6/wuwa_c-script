using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F0 RID: 17392
	public static class IPositionRollbackConfigVerify
	{
		// Token: 0x06018B70 RID: 101232 RVA: 0x00385E28 File Offset: 0x00384028
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPositionRollbackConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPositionRollbackConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPositionRollbackConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPositionRollbackConfigVerify.<>O.<1>__Verify = new VerifyTableAction(Aki.UniverseEditor.Interface.Fbs.Action.IPosAVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008165 RID: 33125
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401426C RID: 82540
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401426D RID: 82541
			public static VerifyTableAction <1>__Verify;
		}
	}
}
