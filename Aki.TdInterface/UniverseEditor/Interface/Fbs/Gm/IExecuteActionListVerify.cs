using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004647 RID: 17991
	public static class IExecuteActionListVerify
	{
		// Token: 0x0601B40E RID: 111630 RVA: 0x003E0D7C File Offset: 0x003DEF7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExecuteActionListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecuteActionListVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079CE RID: 31182
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401336A RID: 78698
			public static VerifyTableAction <0>__Verify;
		}
	}
}
