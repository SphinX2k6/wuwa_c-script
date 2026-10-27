using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200527E RID: 21118
	public static class IFlowComponentVerify
	{
		// Token: 0x06022612 RID: 140818 RVA: 0x004C3F5C File Offset: 0x004C215C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B26 RID: 31526
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401355F RID: 79199
			public static VerifyTableAction <0>__Verify;
		}
	}
}
