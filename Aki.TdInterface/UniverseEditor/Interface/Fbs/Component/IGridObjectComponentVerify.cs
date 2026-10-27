using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200532F RID: 21295
	public static class IGridObjectComponentVerify
	{
		// Token: 0x06022D0D RID: 142605 RVA: 0x004D2F20 File Offset: 0x004D1120
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGridObjectComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGridObjectComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B4A RID: 31562
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013596 RID: 79254
			public static VerifyTableAction <0>__Verify;
		}
	}
}
