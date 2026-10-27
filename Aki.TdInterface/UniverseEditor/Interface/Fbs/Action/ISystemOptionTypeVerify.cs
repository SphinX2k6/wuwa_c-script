using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007288 RID: 29320
	public static class ISystemOptionTypeVerify
	{
		// Token: 0x06034068 RID: 213096 RVA: 0x006FECD8 File Offset: 0x006FCED8
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

		// Token: 0x02007E7E RID: 32382
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A62 RID: 80482
			public static VerifyTableAction <0>__Verify;
		}
	}
}
