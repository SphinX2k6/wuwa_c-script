using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FA RID: 22010
	public static class IDollComboCameraConfigVerify
	{
		// Token: 0x06023124 RID: 143652 RVA: 0x004D3D4C File Offset: 0x004D1F4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollComboCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollComboCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008330 RID: 33584
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401455C RID: 83292
			public static VerifyTableAction <0>__Verify;
		}
	}
}
