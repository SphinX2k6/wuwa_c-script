using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007177 RID: 29047
	public static class ILongPressProgressActionVerify
	{
		// Token: 0x060327C3 RID: 206787 RVA: 0x006D2B68 File Offset: 0x006D0D68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILongPressProgressActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILongPressProgressActionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008620 RID: 34336
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149EE RID: 84462
			public static VerifyTableAction <0>__Verify;
		}
	}
}
