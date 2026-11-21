using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046BA RID: 18106
	public static class IUseVarVerify
	{
		// Token: 0x0601A9B8 RID: 108984 RVA: 0x003C8B08 File Offset: 0x003C6D08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IUseVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUseVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081C4 RID: 33220
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401435B RID: 82779
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
