using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EBF RID: 16063
	public static class IItemTypeVariableVerify
	{
		// Token: 0x06016B34 RID: 92980 RVA: 0x00347020 File Offset: 0x00345220
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IItemTypeVariableVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemTypeVariableVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078FA RID: 30970
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131B8 RID: 78264
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
