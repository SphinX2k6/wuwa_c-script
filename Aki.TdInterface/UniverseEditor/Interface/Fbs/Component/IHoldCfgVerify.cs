using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AC RID: 21420
	public static class IHoldCfgVerify
	{
		// Token: 0x06023163 RID: 143715 RVA: 0x004DB64D File Offset: 0x004D984D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHoldCfgVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHoldCfgVerify.<>O.<0>__Verify = new VerifyTableAction(IHoldingTrackTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B59 RID: 31577
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135AE RID: 79278
			public static VerifyTableAction <0>__Verify;
		}
	}
}
