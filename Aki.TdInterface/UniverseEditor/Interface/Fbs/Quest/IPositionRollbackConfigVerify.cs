using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FAF RID: 16303
	public static class IPositionRollbackConfigVerify
	{
		// Token: 0x060174E1 RID: 95457 RVA: 0x0035C210 File Offset: 0x0035A410
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

		// Token: 0x0200791E RID: 31006
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401320A RID: 78346
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401320B RID: 78347
			public static VerifyTableAction <1>__Verify;
		}
	}
}
