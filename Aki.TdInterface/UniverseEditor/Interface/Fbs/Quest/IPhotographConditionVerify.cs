using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F82 RID: 16258
	public static class IPhotographConditionVerify
	{
		// Token: 0x0601736F RID: 95087 RVA: 0x003597C4 File Offset: 0x003579C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPhotographConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TPhotographTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007915 RID: 30997
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013200 RID: 78336
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
