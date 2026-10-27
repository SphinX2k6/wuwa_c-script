using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBD RID: 23485
	public static class IWuWaGoHintStepMoveVerify
	{
		// Token: 0x0602837E RID: 164734 RVA: 0x00586A08 File Offset: 0x00584C08
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

		// Token: 0x02007C86 RID: 31878
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B0 RID: 79792
			public static VerifyTableAction <0>__Verify;
		}
	}
}
