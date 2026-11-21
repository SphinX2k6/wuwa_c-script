using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B0 RID: 17584
	public static class IReadMailConditionVerify
	{
		// Token: 0x06019631 RID: 103985 RVA: 0x0039FA08 File Offset: 0x0039DC08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReadMailConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReadMailConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200818D RID: 33165
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142C6 RID: 82630
			public static VerifyTableAction <0>__Verify;
		}
	}
}
