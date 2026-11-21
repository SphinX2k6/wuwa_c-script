using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077ED RID: 30701
	public static class ISetMotorSpeedTargetSpeedVerify
	{
		// Token: 0x06035EFE RID: 220926 RVA: 0x00739BBC File Offset: 0x00737DBC
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

		// Token: 0x020086D7 RID: 34519
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ADE RID: 84702
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
