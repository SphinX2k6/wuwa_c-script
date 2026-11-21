using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C1 RID: 18881
	public static class IRollBlockBoardConfigVerify
	{
		// Token: 0x0601C373 RID: 115571 RVA: 0x003FBEC0 File Offset: 0x003FA0C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockBoardConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockBoardConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081FF RID: 33279
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143B8 RID: 82872
			public static VerifyTableAction <0>__Verify;
		}
	}
}
