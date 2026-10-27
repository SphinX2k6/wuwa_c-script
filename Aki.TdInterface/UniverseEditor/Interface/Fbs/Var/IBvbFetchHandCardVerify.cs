using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A56 RID: 14934
	public static class IBvbFetchHandCardVerify
	{
		// Token: 0x060143BF RID: 82879 RVA: 0x002F4C38 File Offset: 0x002F2E38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBvbFetchHandCardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbFetchHandCardVerify.<>O.<0>__Verify = new VerifyTableAction(IBvbCardFilterGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007874 RID: 30836
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130DC RID: 78044
			public static VerifyTableAction <0>__Verify;
		}
	}
}
