using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6D RID: 23149
	public static class ILevelPrefabParamsConfigVerify
	{
		// Token: 0x06025E6A RID: 155242 RVA: 0x005321E8 File Offset: 0x005303E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILevelPrefabParamsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPrefabParamsConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TParamsPresetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083E0 RID: 33760
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014688 RID: 83592
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
