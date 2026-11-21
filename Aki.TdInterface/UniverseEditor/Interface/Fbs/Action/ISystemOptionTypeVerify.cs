using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A5D RID: 31325
	public static class ISystemOptionTypeVerify
	{
		// Token: 0x0603736A RID: 226154 RVA: 0x00760038 File Offset: 0x0075E238
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISystemOptionTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemOptionTypeVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008715 RID: 34581
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B39 RID: 84793
			public static VerifyTableAction <0>__Verify;
		}
	}
}
