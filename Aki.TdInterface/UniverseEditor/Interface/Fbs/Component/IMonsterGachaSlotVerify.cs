using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1E RID: 23326
	public static class IMonsterGachaSlotVerify
	{
		// Token: 0x060265D1 RID: 157137 RVA: 0x005416C5 File Offset: 0x0053F8C5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterGachaSlotVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterGachaSlotVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083F6 RID: 33782
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146B0 RID: 83632
			public static VerifyTableAction <0>__Verify;
		}
	}
}
