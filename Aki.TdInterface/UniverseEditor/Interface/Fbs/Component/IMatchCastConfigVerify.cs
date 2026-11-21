using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA9 RID: 23209
	public static class IMatchCastConfigVerify
	{
		// Token: 0x060260C8 RID: 155848 RVA: 0x00536AF8 File Offset: 0x00534CF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMatchCastConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMatchCastConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMatchSequenceVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083E8 RID: 33768
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014693 RID: 83603
			public static VerifyTableAction <0>__Verify;
		}
	}
}
