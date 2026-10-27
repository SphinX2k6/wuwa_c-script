using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FA RID: 21498
	public static class IInhalationAbilityComponentVerify
	{
		// Token: 0x060234E6 RID: 144614 RVA: 0x004E3444 File Offset: 0x004E1644
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInhalationAbilityComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInhalationAbilityComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IInhalationConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B64 RID: 31588
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135C6 RID: 79302
			public static VerifyTableAction <0>__Verify;
		}
	}
}
