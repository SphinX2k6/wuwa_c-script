using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CE RID: 27086
	public static class IJigsawConfigVerify
	{
		// Token: 0x0602F58E RID: 193934 RVA: 0x00672B50 File Offset: 0x00670D50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IJigsawConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IJigsawPieceVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D96 RID: 32150
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013929 RID: 80169
			public static VerifyTableAction <0>__Verify;
		}
	}
}
