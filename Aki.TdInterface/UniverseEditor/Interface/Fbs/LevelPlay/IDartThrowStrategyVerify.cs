using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004904 RID: 18692
	public static class IDartThrowStrategyVerify
	{
		// Token: 0x0601BB54 RID: 113492 RVA: 0x003EB374 File Offset: 0x003E9574
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDartThrowStrategyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartThrowStrategyVerify.<>O.<0>__Verify = new VerifyTableAction(IDartStrategyErrorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081EE RID: 33262
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014396 RID: 82838
			public static VerifyTableAction <0>__Verify;
		}
	}
}
