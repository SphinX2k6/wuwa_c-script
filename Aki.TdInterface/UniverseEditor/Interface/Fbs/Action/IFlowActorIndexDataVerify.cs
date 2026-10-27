using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F1 RID: 26609
	public static class IFlowActorIndexDataVerify
	{
		// Token: 0x0602E546 RID: 189766 RVA: 0x0065310C File Offset: 0x0065130C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowActorIndexDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowActorIndexDataVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D73 RID: 32115
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F6 RID: 80118
			public static VerifyTableAction <0>__Verify;
		}
	}
}
