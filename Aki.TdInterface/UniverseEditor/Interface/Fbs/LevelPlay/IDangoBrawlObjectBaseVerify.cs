using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C8 RID: 18632
	public static class IDangoBrawlObjectBaseVerify
	{
		// Token: 0x0601B90C RID: 112908 RVA: 0x003E5EB4 File Offset: 0x003E40B4
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

		// Token: 0x020081E7 RID: 33255
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014389 RID: 82825
			public static VerifyTableAction <0>__Verify;
		}
	}
}
