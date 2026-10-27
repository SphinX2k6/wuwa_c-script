using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EAC RID: 20140
	public static class IAnimalModelVerify
	{
		// Token: 0x0601FB77 RID: 129911 RVA: 0x0046A7D8 File Offset: 0x004689D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAnimalModelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAnimalModelVerify.<>O.<0>__Verify = new VerifyTableAction(IMeshAnimalModelVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A80 RID: 31360
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013451 RID: 78929
			public static VerifyTableAction <0>__Verify;
		}
	}
}
