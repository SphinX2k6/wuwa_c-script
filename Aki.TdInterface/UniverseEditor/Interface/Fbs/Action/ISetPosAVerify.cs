using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705D RID: 28765
	public static class ISetPosAVerify
	{
		// Token: 0x06032EF5 RID: 208629 RVA: 0x006DF421 File Offset: 0x006DD621
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetPosAVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetPosAVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E4D RID: 32333
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A22 RID: 80418
			public static VerifyTableAction <0>__Verify;
		}
	}
}
