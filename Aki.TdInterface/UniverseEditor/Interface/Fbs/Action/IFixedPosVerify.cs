using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D0 RID: 26576
	public static class IFixedPosVerify
	{
		// Token: 0x0602E446 RID: 189510 RVA: 0x00651728 File Offset: 0x0064F928
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedPosVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D70 RID: 32112
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F3 RID: 80115
			public static VerifyTableAction <0>__Verify;
		}
	}
}
