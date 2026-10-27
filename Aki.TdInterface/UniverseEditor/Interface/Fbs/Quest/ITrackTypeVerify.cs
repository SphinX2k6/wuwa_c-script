using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421F RID: 16927
	public static class ITrackTypeVerify
	{
		// Token: 0x06019069 RID: 102505 RVA: 0x00399F58 File Offset: 0x00398158
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

		// Token: 0x02007976 RID: 31094
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132EE RID: 78574
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
