using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F96 RID: 20374
	public static class IChessmanComponentVerify
	{
		// Token: 0x06020636 RID: 132662 RVA: 0x0048186C File Offset: 0x0047FA6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChessmanComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChessmanComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IChessmanComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IChessmanComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AAB RID: 31403
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013497 RID: 78999
			public static VerifyTableAction <0>__Verify;
		}
	}
}
