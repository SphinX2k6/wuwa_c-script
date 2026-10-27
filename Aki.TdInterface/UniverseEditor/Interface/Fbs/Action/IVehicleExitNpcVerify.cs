using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007519 RID: 29977
	public static class IVehicleExitNpcVerify
	{
		// Token: 0x06036860 RID: 223328 RVA: 0x007682A0 File Offset: 0x007664A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleExitNpcVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleExitNpcVerify.<>O.<0>__Verify = new VerifyUnionAction(TExitVehicleTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EC0 RID: 32448
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C0B RID: 80907
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
