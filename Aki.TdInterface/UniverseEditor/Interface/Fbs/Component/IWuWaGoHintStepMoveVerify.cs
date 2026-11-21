using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D3 RID: 25043
	public static class IWuWaGoHintStepMoveVerify
	{
		// Token: 0x0602A942 RID: 174402 RVA: 0x005CE498 File Offset: 0x005CC698
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoHintStepMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoHintStepMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084F7 RID: 34039
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014856 RID: 84054
			public static VerifyTableAction <0>__Verify;
		}
	}
}
