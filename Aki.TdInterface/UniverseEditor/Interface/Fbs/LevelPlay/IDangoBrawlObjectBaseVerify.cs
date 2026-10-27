using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004460 RID: 17504
	public static class IDangoBrawlObjectBaseVerify
	{
		// Token: 0x0601A13B RID: 106811 RVA: 0x003B9CA8 File Offset: 0x003B7EA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDangoBrawlObjectBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDangoBrawlObjectBaseVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200799E RID: 31134
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013322 RID: 78626
			public static VerifyTableAction <0>__Verify;
		}
	}
}
