using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AED RID: 27373
	public static class ICommonTip2Verify
	{
		// Token: 0x0602F0E3 RID: 192739 RVA: 0x0066B745 File Offset: 0x00669945
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

		// Token: 0x020085A7 RID: 34215
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401494C RID: 84300
			public static VerifyTableAction <0>__Verify;
		}
	}
}
