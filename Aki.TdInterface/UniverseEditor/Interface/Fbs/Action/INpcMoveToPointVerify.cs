using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDB RID: 27611
	public static class INpcMoveToPointVerify
	{
		// Token: 0x0603081B RID: 198683 RVA: 0x00695F1C File Offset: 0x0069411C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcMoveToPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcMoveToPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DCB RID: 32203
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401396F RID: 80239
			public static VerifyTableAction <0>__Verify;
		}
	}
}
