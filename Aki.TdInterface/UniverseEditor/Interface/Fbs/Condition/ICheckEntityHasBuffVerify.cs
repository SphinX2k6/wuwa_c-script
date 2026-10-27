using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A05 RID: 18949
	public static class ICheckEntityHasBuffVerify
	{
		// Token: 0x0601DA1B RID: 121371 RVA: 0x0042B9AC File Offset: 0x00429BAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckEntityHasBuffVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntityHasBuffVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterBuffContainerVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A2C RID: 31276
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F0 RID: 78832
			public static VerifyTableAction <0>__Verify;
		}
	}
}
