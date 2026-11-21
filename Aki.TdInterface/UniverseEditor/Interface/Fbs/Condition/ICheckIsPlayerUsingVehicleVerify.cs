using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F67 RID: 20327
	public static class ICheckIsPlayerUsingVehicleVerify
	{
		// Token: 0x0601FA32 RID: 129586 RVA: 0x00466408 File Offset: 0x00464608
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckIsPlayerUsingVehicleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckIsPlayerUsingVehicleVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008289 RID: 33417
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401446B RID: 83051
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
