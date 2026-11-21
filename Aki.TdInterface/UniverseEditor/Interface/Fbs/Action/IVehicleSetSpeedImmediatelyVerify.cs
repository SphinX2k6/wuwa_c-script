using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D27 RID: 32039
	public static class IVehicleSetSpeedImmediatelyVerify
	{
		// Token: 0x06039D76 RID: 236918 RVA: 0x007CDC0C File Offset: 0x007CBE0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleSetSpeedImmediatelyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleSetSpeedImmediatelyVerify.<>O.<0>__Verify = new VerifyUnionAction(TVehicleSetSpeedImmediatelyVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008761 RID: 34657
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CED RID: 85229
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
