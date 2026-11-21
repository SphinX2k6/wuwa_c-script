using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004219 RID: 16921
	public static class IDistributeParamsVerify
	{
		// Token: 0x06017815 RID: 96277 RVA: 0x0035B12C File Offset: 0x0035932C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDistributeParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDistributeParamsVerify.<>O.<0>__Verify = new VerifyTableAction(IItemConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008119 RID: 33049
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141D3 RID: 82387
			public static VerifyTableAction <0>__Verify;
		}
	}
}
