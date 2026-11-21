using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C6 RID: 22726
	public static class IGroupAiMonsterEcologyVerify
	{
		// Token: 0x06024E55 RID: 151125 RVA: 0x00510F78 File Offset: 0x0050F178
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGroupAiMonsterEcologyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupAiMonsterEcologyVerify.<>O.<0>__Verify = new VerifyTableAction(IGroupAiMonsterMemberVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083AB RID: 33707
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401461D RID: 83485
			public static VerifyTableAction <0>__Verify;
		}
	}
}
