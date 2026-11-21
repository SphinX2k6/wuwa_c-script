using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056ED RID: 22253
	public static class IEntityGroupFailureSequentialStateVerify
	{
		// Token: 0x06023B5C RID: 146268 RVA: 0x004E8D68 File Offset: 0x004E6F68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityGroupFailureSequentialStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityGroupFailureSequentialStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008356 RID: 33622
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401459D RID: 83357
			public static VerifyTableAction <0>__Verify;
		}
	}
}
