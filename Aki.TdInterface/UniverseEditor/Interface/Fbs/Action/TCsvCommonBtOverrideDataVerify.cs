using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769A RID: 30362
	public static class TCsvCommonBtOverrideDataVerify
	{
		// Token: 0x060373ED RID: 226285 RVA: 0x0077C924 File Offset: 0x0077AB24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvCommonBtOverrideDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvCommonBtOverrideDataVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtOverrideVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EDD RID: 32477
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C2F RID: 80943
			public static VerifyTableAction <0>__Verify;
		}
	}
}
