using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545F RID: 21599
	public static class IBuffAreaStateConfigVerify
	{
		// Token: 0x06021EAF RID: 138927 RVA: 0x004ACCF0 File Offset: 0x004AAEF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfData(tablePos, 6, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBuffAreaStateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBuffAreaStateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082EB RID: 33515
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144EB RID: 83179
			public static VerifyTableAction <0>__Verify;
		}
	}
}
