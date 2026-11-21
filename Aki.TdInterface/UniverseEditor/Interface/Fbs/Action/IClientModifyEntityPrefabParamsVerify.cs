using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4F RID: 27215
	public static class IClientModifyEntityPrefabParamsVerify
	{
		// Token: 0x0602EB06 RID: 191238 RVA: 0x0065D4C0 File Offset: 0x0065B6C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientModifyEntityPrefabParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientModifyEntityPrefabParamsVerify.<>O.<0>__Verify = new VerifyUnionAction(TParamsPresetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008595 RID: 34197
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014936 RID: 84278
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
