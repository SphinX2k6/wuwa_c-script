using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E74 RID: 20084
	public static class ICheckDangoCultivationProgressVerify
	{
		// Token: 0x0601F1BC RID: 127420 RVA: 0x004572D8 File Offset: 0x004554D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckDangoCultivationProgressVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckDangoCultivationProgressVerify.<>O.<0>__Verify = new VerifyTableAction(ICountDangoOverTargetLevelVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008272 RID: 33394
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014453 RID: 83027
			public static VerifyTableAction <0>__Verify;
		}
	}
}
