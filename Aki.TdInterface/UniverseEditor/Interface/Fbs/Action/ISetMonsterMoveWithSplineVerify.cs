using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701E RID: 28702
	public static class ISetMonsterMoveWithSplineVerify
	{
		// Token: 0x06032C54 RID: 207956 RVA: 0x006D9654 File Offset: 0x006D7854
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetMonsterMoveWithSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetMonsterMoveWithSplineVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterMoveSplineConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E40 RID: 32320
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A0A RID: 80394
			public static VerifyTableAction <0>__Verify;
		}
	}
}
