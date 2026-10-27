using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DBD RID: 15805
	public static class IConditionTrackPosVerify
	{
		// Token: 0x060160D2 RID: 90322 RVA: 0x0033063C File Offset: 0x0032E83C
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

		// Token: 0x020078CD RID: 30925
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401316D RID: 78189
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401316E RID: 78190
			public static VerifyTableAction <1>__Verify;
		}
	}
}
