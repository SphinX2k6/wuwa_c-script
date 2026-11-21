using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006117 RID: 24855
	public static class IUndergroundStateInfoVerify
	{
		// Token: 0x0602A239 RID: 172601 RVA: 0x005C0494 File Offset: 0x005BE694
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUndergroundStateInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUndergroundStateInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084E3 RID: 34019
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014838 RID: 84024
			public static VerifyTableAction <0>__Verify;
		}
	}
}
