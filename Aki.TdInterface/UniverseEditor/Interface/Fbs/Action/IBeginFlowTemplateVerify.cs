using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006870 RID: 26736
	public static class IBeginFlowTemplateVerify
	{
		// Token: 0x0602DB4F RID: 187215 RVA: 0x00640148 File Offset: 0x0063E348
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBeginFlowTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBeginFlowTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowActorUnitVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008568 RID: 34152
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148FC RID: 84220
			public static VerifyTableAction <0>__Verify;
		}
	}
}
