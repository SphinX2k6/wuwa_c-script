using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043EA RID: 17386
	public static class IPlotHandBookItemVerify
	{
		// Token: 0x06018B3A RID: 101178 RVA: 0x00385768 File Offset: 0x00383968
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

		// Token: 0x02008163 RID: 33123
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401426A RID: 82538
			public static VerifyTableAction <0>__Verify;
		}
	}
}
