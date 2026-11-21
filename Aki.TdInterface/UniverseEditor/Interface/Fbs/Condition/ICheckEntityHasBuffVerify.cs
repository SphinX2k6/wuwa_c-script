using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC5 RID: 20165
	public static class ICheckEntityHasBuffVerify
	{
		// Token: 0x0601F48E RID: 128142 RVA: 0x0045C618 File Offset: 0x0045A818
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

		// Token: 0x0200827B RID: 33403
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401445D RID: 83037
			public static VerifyTableAction <0>__Verify;
		}
	}
}
