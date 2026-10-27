using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0E RID: 27662
	public static class IOpenLevelQteVerify
	{
		// Token: 0x06030A46 RID: 199238 RVA: 0x0069A700 File Offset: 0x00698900
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenLevelQteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenLevelQteVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DD3 RID: 32211
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013978 RID: 80248
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
