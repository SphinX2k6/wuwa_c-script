using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AE RID: 30638
	public static class ISetEntityPosVerify
	{
		// Token: 0x06035CB3 RID: 220339 RVA: 0x00734E44 File Offset: 0x00733044
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetEntityPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetEntityPosVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISetEntityPosVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetEntityPosVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086CD RID: 34509
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC8 RID: 84680
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014AC9 RID: 84681
			public static VerifyTableAction <1>__Verify;
		}
	}
}
