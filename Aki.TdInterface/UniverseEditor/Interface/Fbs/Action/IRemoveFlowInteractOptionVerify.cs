using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4E RID: 28238
	public static class IRemoveFlowInteractOptionVerify
	{
		// Token: 0x06031E67 RID: 204391 RVA: 0x006C0888 File Offset: 0x006BEA88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRemoveFlowInteractOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemoveFlowInteractOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E0D RID: 32269
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C8 RID: 80328
			public static VerifyTableAction <0>__Verify;
		}
	}
}
