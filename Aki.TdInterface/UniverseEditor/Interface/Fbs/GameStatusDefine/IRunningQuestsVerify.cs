using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B73 RID: 19315
	public static class IRunningQuestsVerify
	{
		// Token: 0x0601D62D RID: 120365 RVA: 0x004205A0 File Offset: 0x0041E7A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunningQuestsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunningQuestsVerify.<>O.<0>__Verify = new VerifyTableAction(IRunningTreeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRunningQuestsVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRunningQuestsVerify.<>O.<0>__Verify = new VerifyTableAction(IRunningTreeVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008220 RID: 33312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143E1 RID: 82913
			public static VerifyTableAction <0>__Verify;
		}
	}
}
