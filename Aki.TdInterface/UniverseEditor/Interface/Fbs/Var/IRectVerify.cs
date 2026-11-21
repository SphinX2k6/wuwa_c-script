using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EBE RID: 16062
	public static class IRectVerify
	{
		// Token: 0x06015BCD RID: 89037 RVA: 0x00320F7C File Offset: 0x0031F17C
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

		// Token: 0x020080BF RID: 32959
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401413F RID: 82239
			public static VerifyTableAction <0>__Verify;
		}
	}
}
