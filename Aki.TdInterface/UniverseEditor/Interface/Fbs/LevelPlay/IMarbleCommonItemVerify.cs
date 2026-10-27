using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004523 RID: 17699
	public static class IMarbleCommonItemVerify
	{
		// Token: 0x0601A9BA RID: 108986 RVA: 0x003CC5B0 File Offset: 0x003CA7B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMarbleCommonItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMarbleCommonItemVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B2 RID: 31154
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401334D RID: 78669
			public static VerifyTableAction <0>__Verify;
		}
	}
}
