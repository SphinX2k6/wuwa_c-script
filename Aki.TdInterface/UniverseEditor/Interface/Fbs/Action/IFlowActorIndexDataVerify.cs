using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E71 RID: 28273
	public static class IFlowActorIndexDataVerify
	{
		// Token: 0x06030D8C RID: 200076 RVA: 0x006A0850 File Offset: 0x0069EA50
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

		// Token: 0x020085EA RID: 34282
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149A2 RID: 84386
			public static VerifyTableAction <0>__Verify;
		}
	}
}
