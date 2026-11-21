using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E7 RID: 30695
	public static class ISetMonsterMoveWithSplineVerify
	{
		// Token: 0x06035EBA RID: 220858 RVA: 0x00739298 File Offset: 0x00737498
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

		// Token: 0x020086D5 RID: 34517
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ADB RID: 84699
			public static VerifyTableAction <0>__Verify;
		}
	}
}
