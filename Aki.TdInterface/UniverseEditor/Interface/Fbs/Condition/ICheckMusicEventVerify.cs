using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA0 RID: 20384
	public static class ICheckMusicEventVerify
	{
		// Token: 0x0601FC28 RID: 130088 RVA: 0x00469B94 File Offset: 0x00467D94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckMusicEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckMusicEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TMusicConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200828F RID: 33423
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014471 RID: 83057
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
