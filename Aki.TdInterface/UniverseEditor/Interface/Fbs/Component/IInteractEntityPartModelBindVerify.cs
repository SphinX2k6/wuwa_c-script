using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D1 RID: 22993
	public static class IInteractEntityPartModelBindVerify
	{
		// Token: 0x06025890 RID: 153744 RVA: 0x005263D0 File Offset: 0x005245D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractEntityPartModelBindVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractEntityPartModelBindVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractEntityPartModelOptionPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083CB RID: 33739
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014661 RID: 83553
			public static VerifyTableAction <0>__Verify;
		}
	}
}
