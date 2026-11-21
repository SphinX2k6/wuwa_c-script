using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006358 RID: 25432
	public static class IBvbAiChangeDataVerify
	{
		// Token: 0x0602B247 RID: 176711 RVA: 0x005E10DC File Offset: 0x005DF2DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiChangeDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiChangeDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008505 RID: 34053
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014867 RID: 84071
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
