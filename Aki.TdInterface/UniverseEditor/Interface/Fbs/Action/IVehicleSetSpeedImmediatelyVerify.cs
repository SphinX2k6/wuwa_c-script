using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007531 RID: 30001
	public static class IVehicleSetSpeedImmediatelyVerify
	{
		// Token: 0x06036960 RID: 223584 RVA: 0x0076A964 File Offset: 0x00768B64
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

		// Token: 0x02007EC7 RID: 32455
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C13 RID: 80915
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
