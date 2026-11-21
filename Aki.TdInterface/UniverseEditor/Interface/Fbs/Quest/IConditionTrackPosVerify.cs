using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D4 RID: 16852
	public static class IConditionTrackPosVerify
	{
		// Token: 0x0601760B RID: 95755 RVA: 0x003579C4 File Offset: 0x00355BC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionTrackPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionTrackPosVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConditionTrackPosVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionTrackPosVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008111 RID: 33041
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141C9 RID: 82377
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141CA RID: 82378
			public static VerifyTableAction <1>__Verify;
		}
	}
}
