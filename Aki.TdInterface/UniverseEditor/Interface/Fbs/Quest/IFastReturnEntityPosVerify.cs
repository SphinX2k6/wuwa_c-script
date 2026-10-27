using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E1D RID: 15901
	public static class IFastReturnEntityPosVerify
	{
		// Token: 0x0601644F RID: 91215 RVA: 0x003370C8 File Offset: 0x003352C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFastReturnEntityPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFastReturnEntityPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078D8 RID: 30936
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401317D RID: 78205
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
