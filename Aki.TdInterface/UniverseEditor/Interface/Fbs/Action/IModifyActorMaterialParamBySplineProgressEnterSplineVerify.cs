using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB4 RID: 27316
	public static class IModifyActorMaterialParamBySplineProgressEnterSplineVerify
	{
		// Token: 0x0602FDEF RID: 196079 RVA: 0x00683150 File Offset: 0x00681350
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IModifyActorMaterialParamBySplineProgressEnterSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMaterialParamBySplineProgressEnterSplineVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefWithMaterialParamVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DAA RID: 32170
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013945 RID: 80197
			public static VerifyTableAction <0>__Verify;
		}
	}
}
