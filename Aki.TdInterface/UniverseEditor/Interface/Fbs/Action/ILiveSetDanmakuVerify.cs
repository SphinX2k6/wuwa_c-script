using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007129 RID: 28969
	public static class ILiveSetDanmakuVerify
	{
		// Token: 0x06032532 RID: 206130 RVA: 0x006CDDF0 File Offset: 0x006CBFF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILiveSetDanmakuVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveSetDanmakuVerify.<>O.<0>__Verify = new VerifyUnionAction(TLiveDanmakuOperationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008619 RID: 34329
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E3 RID: 84451
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
