using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E59 RID: 20057
	public static class ICheckClientEventVerify
	{
		// Token: 0x0601F0AE RID: 127150 RVA: 0x004553F0 File Offset: 0x004535F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckClientEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckClientEventVerify.<>O.<0>__Verify = new VerifyTableAction(ISelfClientEventVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200826F RID: 33391
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014450 RID: 83024
			public static VerifyTableAction <0>__Verify;
		}
	}
}
