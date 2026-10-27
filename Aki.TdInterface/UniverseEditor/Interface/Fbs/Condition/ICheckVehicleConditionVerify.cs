using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B6A RID: 19306
	public static class ICheckVehicleConditionVerify
	{
		// Token: 0x0601E6B6 RID: 124598 RVA: 0x00442C00 File Offset: 0x00440E00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckVehicleConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckVehicleConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVehicleConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A50 RID: 31312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013418 RID: 78872
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
