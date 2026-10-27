using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ACE RID: 19150
	public static class ICheckMusicEventVerify
	{
		// Token: 0x0601E129 RID: 123177 RVA: 0x004380E8 File Offset: 0x004362E8
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

		// Token: 0x02007A3E RID: 31294
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013402 RID: 78850
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
