using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007024 RID: 28708
	public static class ISetMotorSpeedTargetSpeedVerify
	{
		// Token: 0x06032C98 RID: 208024 RVA: 0x006D9F78 File Offset: 0x006D8178
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetMotorSpeedTargetSpeedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetMotorSpeedTargetSpeedVerify.<>O.<0>__Verify = new VerifyUnionAction(TEaseCurveTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E42 RID: 32322
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A0D RID: 80397
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
