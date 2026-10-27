using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE5 RID: 28645
	public static class ISetEntityPosVerify
	{
		// Token: 0x06032A4D RID: 207437 RVA: 0x006D5200 File Offset: 0x006D3400
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

		// Token: 0x02007E38 RID: 32312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F7 RID: 80375
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139F8 RID: 80376
			public static VerifyTableAction <1>__Verify;
		}
	}
}
