using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007285 RID: 29317
	public static class ISystemOptionVerify
	{
		// Token: 0x06034044 RID: 213060 RVA: 0x006FE824 File Offset: 0x006FCA24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISystemOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E7D RID: 32381
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A61 RID: 80481
			public static VerifyTableAction <0>__Verify;
		}
	}
}
