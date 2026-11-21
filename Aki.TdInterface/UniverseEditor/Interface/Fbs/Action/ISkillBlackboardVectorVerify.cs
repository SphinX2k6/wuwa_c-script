using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F5 RID: 30965
	public static class ISkillBlackboardVectorVerify
	{
		// Token: 0x06036876 RID: 223350 RVA: 0x0074CC9C File Offset: 0x0074AE9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISkillBlackboardVectorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkillBlackboardVectorVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086F9 RID: 34553
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B14 RID: 84756
			public static VerifyTableAction <0>__Verify;
		}
	}
}
