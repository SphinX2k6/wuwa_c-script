using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D32 RID: 19762
	public static class Record_Int_IActorDeployConfigVerify
	{
		// Token: 0x0601EA3C RID: 125500 RVA: 0x00449CB0 File Offset: 0x00447EB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_Int_IActorDeployConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_Int_IActorDeployConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActorDeployConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008261 RID: 33377
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401443F RID: 83007
			public static VerifyTableAction <0>__Verify;
		}
	}
}
