using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200467B RID: 18043
	public static class ITrackTypeVerify
	{
		// Token: 0x0601A7D5 RID: 108501 RVA: 0x003C5630 File Offset: 0x003C3830
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081BF RID: 33215
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014355 RID: 82773
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
