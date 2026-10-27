using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006482 RID: 25730
	public static class ICommonTip2Verify
	{
		// Token: 0x0602C969 RID: 182633 RVA: 0x0061FB71 File Offset: 0x0061DD71
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonTip2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonTip2Verify.<>O.<0>__Verify = new VerifyTableAction(ICommonTip2PrepareCountdownVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D32 RID: 32050
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A1 RID: 80033
			public static VerifyTableAction <0>__Verify;
		}
	}
}
