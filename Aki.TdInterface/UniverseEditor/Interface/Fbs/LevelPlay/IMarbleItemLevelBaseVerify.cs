using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004526 RID: 17702
	public static class IMarbleItemLevelBaseVerify
	{
		// Token: 0x0601A9D8 RID: 109016 RVA: 0x003CC984 File Offset: 0x003CAB84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMarbleItemLevelBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMarbleItemLevelBaseVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B3 RID: 31155
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401334E RID: 78670
			public static VerifyTableAction <0>__Verify;
		}
	}
}
