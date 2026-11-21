using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050C9 RID: 20681
	public static class ICondition2DebugDataVerify
	{
		// Token: 0x0602067A RID: 132730 RVA: 0x0047CCD4 File Offset: 0x0047AED4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICondition2DebugDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICondition2DebugDataVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082AA RID: 33450
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014490 RID: 83088
			public static VerifyTableAction <0>__Verify;
		}
	}
}
