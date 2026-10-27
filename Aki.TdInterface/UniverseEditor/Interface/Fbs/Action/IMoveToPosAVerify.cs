using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B65 RID: 27493
	public static class IMoveToPosAVerify
	{
		// Token: 0x0603043A RID: 197690 RVA: 0x0068ECEC File Offset: 0x0068CEEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMoveToPosAVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveToPosAVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DBE RID: 32190
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401395D RID: 80221
			public static VerifyTableAction <0>__Verify;
		}
	}
}
