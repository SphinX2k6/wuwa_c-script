using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004680 RID: 18048
	public static class IPlayFlowForGmVerify
	{
		// Token: 0x0601B66C RID: 112236 RVA: 0x003E4DD4 File Offset: 0x003E2FD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayFlowForGmVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayFlowForGmVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079CF RID: 31183
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401336B RID: 78699
			public static VerifyTableAction <0>__Verify;
		}
	}
}
