using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007516 RID: 29974
	public static class IVehicleEntityVerify
	{
		// Token: 0x06036844 RID: 223300 RVA: 0x00767E6C File Offset: 0x0076606C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EBF RID: 32447
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C0A RID: 80906
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
