using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005980 RID: 22912
	public static class IInhalationAbilityComponentVerify
	{
		// Token: 0x0602559E RID: 152990 RVA: 0x00520470 File Offset: 0x0051E670
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

		// Token: 0x020083C3 RID: 33731
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401464C RID: 83532
			public static VerifyTableAction <0>__Verify;
		}
	}
}
