using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E7 RID: 21735
	public static class ILevelPrefabParamsConfigVerify
	{
		// Token: 0x06023DB0 RID: 146864 RVA: 0x004F50C4 File Offset: 0x004F32C4
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

		// Token: 0x02007B81 RID: 31617
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013602 RID: 79362
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
