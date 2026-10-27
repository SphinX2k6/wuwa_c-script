using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585A RID: 22618
	public static class IRenjuConfigVerify
	{
		// Token: 0x0602613C RID: 155964 RVA: 0x0053FD8C File Offset: 0x0053DF8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRenjuConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenjuConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C0B RID: 31755
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136E1 RID: 79585
			public static VerifyTableAction <0>__Verify;
		}
	}
}
