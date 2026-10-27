using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005400 RID: 21504
	public static class IInhalationMatchingVerify
	{
		// Token: 0x06023516 RID: 144662 RVA: 0x004E3AE0 File Offset: 0x004E1CE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInhalationMatchingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInhalationMatchingVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B66 RID: 31590
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135C9 RID: 79305
			public static VerifyTableAction <0>__Verify;
		}
	}
}
