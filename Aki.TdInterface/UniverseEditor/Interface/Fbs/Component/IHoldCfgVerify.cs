using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005932 RID: 22834
	public static class IHoldCfgVerify
	{
		// Token: 0x06025217 RID: 152087 RVA: 0x00518521 File Offset: 0x00516721
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

		// Token: 0x020083B8 RID: 33720
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014633 RID: 83507
			public static VerifyTableAction <0>__Verify;
		}
	}
}
