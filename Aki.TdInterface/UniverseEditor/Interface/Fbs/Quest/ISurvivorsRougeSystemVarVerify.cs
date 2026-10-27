using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004171 RID: 16753
	public static class ISurvivorsRougeSystemVarVerify
	{
		// Token: 0x060189C6 RID: 100806 RVA: 0x0038B82C File Offset: 0x00389A2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISurvivorsRougeSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISurvivorsRougeSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007959 RID: 31065
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132A6 RID: 78502
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
