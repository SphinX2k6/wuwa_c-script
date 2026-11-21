using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A5 RID: 22181
	public static class IElementalWellComponentVerify
	{
		// Token: 0x06023837 RID: 145463 RVA: 0x004E27CC File Offset: 0x004E09CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IElementalWellComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalWellComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IWellStreamingRenderConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IElementalWellComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IElementalWellComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IStreamingWaitConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200834B RID: 33611
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401458D RID: 83341
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401458E RID: 83342
			public static VerifyTableAction <1>__Verify;
		}
	}
}
