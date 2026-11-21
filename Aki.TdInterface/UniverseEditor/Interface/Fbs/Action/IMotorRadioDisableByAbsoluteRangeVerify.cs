using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007260 RID: 29280
	public static class IMotorRadioDisableByAbsoluteRangeVerify
	{
		// Token: 0x0603304F RID: 208975 RVA: 0x006E3160 File Offset: 0x006E1360
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMotorRadioDisableByAbsoluteRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorRadioDisableByAbsoluteRangeVerify.<>O.<0>__Verify = new VerifyUnionAction(TRangeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200863D RID: 34365
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A12 RID: 84498
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
