using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005706 RID: 22278
	public static class IPatrolActionVerify
	{
		// Token: 0x060253FA RID: 152570 RVA: 0x00523DA0 File Offset: 0x00521FA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolActionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BCF RID: 31695
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013687 RID: 79495
			public static VerifyTableAction <0>__Verify;
		}
	}
}
