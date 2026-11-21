using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE6 RID: 20198
	public static class ICheckFinishLoadingVerify
	{
		// Token: 0x0601F5B3 RID: 128435 RVA: 0x0045E6A8 File Offset: 0x0045C8A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckFinishLoadingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckFinishLoadingVerify.<>O.<0>__Verify = new VerifyTableAction(IAllPlayerTypeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200827F RID: 33407
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014461 RID: 83041
			public static VerifyTableAction <0>__Verify;
		}
	}
}
