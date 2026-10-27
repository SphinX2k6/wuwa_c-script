using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC2 RID: 16066
	public static class IItemVariableBaseVerify
	{
		// Token: 0x06016B51 RID: 93009 RVA: 0x003474BC File Offset: 0x003456BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IItemVariableBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemVariableBaseVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078FB RID: 30971
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131B9 RID: 78265
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
