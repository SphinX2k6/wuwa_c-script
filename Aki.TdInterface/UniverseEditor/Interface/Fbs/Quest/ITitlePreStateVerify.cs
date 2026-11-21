using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200463F RID: 17983
	public static class ITitlePreStateVerify
	{
		// Token: 0x0601A54F RID: 107855 RVA: 0x003BF730 File Offset: 0x003BD930
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITitlePreStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITitlePreStateVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081B5 RID: 33205
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014337 RID: 82743
			public static VerifyTableAction <0>__Verify;
		}
	}
}
