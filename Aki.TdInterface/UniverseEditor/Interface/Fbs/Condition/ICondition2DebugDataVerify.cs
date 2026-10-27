using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BDC RID: 19420
	public static class ICondition2DebugDataVerify
	{
		// Token: 0x0601EAAC RID: 125612 RVA: 0x00449DC8 File Offset: 0x00447FC8
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

		// Token: 0x02007A58 RID: 31320
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013420 RID: 78880
			public static VerifyTableAction <0>__Verify;
		}
	}
}
