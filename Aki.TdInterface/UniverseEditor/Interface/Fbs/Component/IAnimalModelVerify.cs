using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D5 RID: 21461
	public static class IAnimalModelVerify
	{
		// Token: 0x06021878 RID: 137336 RVA: 0x0049FC54 File Offset: 0x0049DE54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAnimalModelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAnimalModelVerify.<>O.<0>__Verify = new VerifyTableAction(IMeshAnimalModelVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082D4 RID: 33492
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144C4 RID: 83140
			public static VerifyTableAction <0>__Verify;
		}
	}
}
