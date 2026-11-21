using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416B RID: 16747
	public static class ICheckMonsterBattleAttributeVerify
	{
		// Token: 0x060170BA RID: 94394 RVA: 0x00349454 File Offset: 0x00347654
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckMonsterBattleAttributeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckMonsterBattleAttributeVerify.<>O.<0>__Verify = new VerifyTableAction(IHealthAttributeToTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080FE RID: 33022
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401418F RID: 82319
			public static VerifyTableAction <0>__Verify;
		}
	}
}
