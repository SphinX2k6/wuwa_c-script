using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABA RID: 27322
	public static class IModifyActorMediaVerify
	{
		// Token: 0x0602FE17 RID: 196119 RVA: 0x00683575 File Offset: 0x00681775
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IModifyActorMediaVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMediaVerify.<>O.<0>__Verify = new VerifyTableAction(IChangeMediaPlayDaVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DAB RID: 32171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013946 RID: 80198
			public static VerifyTableAction <0>__Verify;
		}
	}
}
