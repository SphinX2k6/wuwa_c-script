using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E20 RID: 15904
	public static class IFastReturnGravityEntityPosVerify
	{
		// Token: 0x06016476 RID: 91254 RVA: 0x003377F4 File Offset: 0x003359F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFastReturnGravityEntityPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFastReturnGravityEntityPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078D9 RID: 30937
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401317E RID: 78206
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
