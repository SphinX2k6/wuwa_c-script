using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AE RID: 21678
	public static class IJigsawItemVerify
	{
		// Token: 0x06023B25 RID: 146213 RVA: 0x004EF688 File Offset: 0x004ED888
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IJigsawItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TFillConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B76 RID: 31606
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135EE RID: 79342
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
