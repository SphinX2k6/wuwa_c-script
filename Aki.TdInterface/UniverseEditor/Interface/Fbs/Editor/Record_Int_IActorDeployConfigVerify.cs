using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048CD RID: 18637
	public static class Record_Int_IActorDeployConfigVerify
	{
		// Token: 0x0601D24F RID: 119375 RVA: 0x0041D514 File Offset: 0x0041B714
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

		// Token: 0x02007A18 RID: 31256
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133D9 RID: 78809
			public static VerifyTableAction <0>__Verify;
		}
	}
}
