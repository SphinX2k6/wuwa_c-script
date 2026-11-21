using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E74 RID: 28276
	public static class IFlowActorUnitVerify
	{
		// Token: 0x06030DB4 RID: 200116 RVA: 0x006A0D24 File Offset: 0x0069EF24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowActorUnitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowActorUnitVerify.<>O.<0>__Verify = new VerifyTableAction(IActorInitialStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085EB RID: 34283
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149A3 RID: 84387
			public static VerifyTableAction <0>__Verify;
		}
	}
}
