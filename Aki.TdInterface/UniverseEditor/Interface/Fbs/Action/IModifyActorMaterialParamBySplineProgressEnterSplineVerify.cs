using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DF RID: 29151
	public static class IModifyActorMaterialParamBySplineProgressEnterSplineVerify
	{
		// Token: 0x06032B63 RID: 207715 RVA: 0x006D9B70 File Offset: 0x006D7D70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModifyActorMaterialParamBySplineProgressEnterSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMaterialParamBySplineProgressEnterSplineVerify.<>O.<0>__Verify = new VerifyUnionAction(TModifyActorMaterialParamBySplineProgressTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IModifyActorMaterialParamBySplineProgressEnterSplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IModifyActorMaterialParamBySplineProgressEnterSplineVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefWithMaterialParamVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200862E RID: 34350
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149FF RID: 84479
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014A00 RID: 84480
			public static VerifyTableAction <1>__Verify;
		}
	}
}
