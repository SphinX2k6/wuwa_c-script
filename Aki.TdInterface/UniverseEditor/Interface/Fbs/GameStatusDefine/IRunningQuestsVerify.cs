using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200470B RID: 18187
	public static class IRunningQuestsVerify
	{
		// Token: 0x0601BE58 RID: 114264 RVA: 0x003F4304 File Offset: 0x003F2504
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

		// Token: 0x020079D7 RID: 31191
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401337A RID: 78714
			public static VerifyTableAction <0>__Verify;
		}
	}
}
