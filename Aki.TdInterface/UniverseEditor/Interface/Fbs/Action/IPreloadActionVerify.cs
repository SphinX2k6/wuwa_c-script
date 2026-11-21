using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007506 RID: 29958
	public static class IPreloadActionVerify
	{
		// Token: 0x0603489A RID: 215194 RVA: 0x0071270C File Offset: 0x0071090C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPreloadActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreloadActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TPreloadObjectTypeConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008690 RID: 34448
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A83 RID: 84611
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
