using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004057 RID: 16471
	public static class IQuestStatisticsTypeVerify
	{
		// Token: 0x06017E0B RID: 97803 RVA: 0x003721F8 File Offset: 0x003703F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestStatisticsTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestStatisticsTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007940 RID: 31040
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013259 RID: 78425
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
