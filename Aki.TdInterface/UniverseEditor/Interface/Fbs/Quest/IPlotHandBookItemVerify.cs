using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA9 RID: 16297
	public static class IPlotHandBookItemVerify
	{
		// Token: 0x060174AB RID: 95403 RVA: 0x0035BB50 File Offset: 0x00359D50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlotHandBookItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlotHandBookItemVerify.<>O.<0>__Verify = new VerifyTableAction(IPlotHandBookNodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200791C RID: 31004
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013208 RID: 78344
			public static VerifyTableAction <0>__Verify;
		}
	}
}
