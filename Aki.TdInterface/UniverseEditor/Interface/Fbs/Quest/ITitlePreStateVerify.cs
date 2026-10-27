using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E6 RID: 16870
	public static class ITitlePreStateVerify
	{
		// Token: 0x06018DF9 RID: 101881 RVA: 0x003942DC File Offset: 0x003924DC
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

		// Token: 0x0200796C RID: 31084
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132D1 RID: 78545
			public static VerifyTableAction <0>__Verify;
		}
	}
}
