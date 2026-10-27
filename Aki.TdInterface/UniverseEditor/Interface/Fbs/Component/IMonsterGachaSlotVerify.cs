using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005580 RID: 21888
	public static class IMonsterGachaSlotVerify
	{
		// Token: 0x060243C4 RID: 148420 RVA: 0x0050114D File Offset: 0x004FF34D
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

		// Token: 0x02007B94 RID: 31636
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013621 RID: 79393
			public static VerifyTableAction <0>__Verify;
		}
	}
}
