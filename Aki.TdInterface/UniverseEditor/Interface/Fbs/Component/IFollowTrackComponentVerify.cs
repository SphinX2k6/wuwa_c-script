using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005816 RID: 22550
	public static class IFollowTrackComponentVerify
	{
		// Token: 0x060247D8 RID: 149464 RVA: 0x005038F8 File Offset: 0x00501AF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFollowTrackComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowTrackComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TFollowTrackEndOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200838B RID: 33675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145EE RID: 83438
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
