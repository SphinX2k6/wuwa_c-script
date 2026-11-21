using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005558 RID: 21848
	public static class IConditionListenerComponentVerify
	{
		// Token: 0x06022AC6 RID: 142022 RVA: 0x004C69AC File Offset: 0x004C4BAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionListenerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionListenerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICondtionListenerVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200831A RID: 33562
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014531 RID: 83249
			public static VerifyTableAction <0>__Verify;
		}
	}
}
