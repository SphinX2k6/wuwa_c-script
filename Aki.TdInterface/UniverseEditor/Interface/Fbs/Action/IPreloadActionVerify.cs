using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8B RID: 28043
	public static class IPreloadActionVerify
	{
		// Token: 0x0603189E RID: 202910 RVA: 0x006B7024 File Offset: 0x006B5224
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

		// Token: 0x02007E04 RID: 32260
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139BF RID: 80319
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
