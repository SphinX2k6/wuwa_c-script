using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ABC RID: 15036
	public static class IRectVerify
	{
		// Token: 0x06014723 RID: 83747 RVA: 0x002FACEC File Offset: 0x002F8EEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRectVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRectVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRectVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200787C RID: 30844
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E4 RID: 78052
			public static VerifyTableAction <0>__Verify;
		}
	}
}
