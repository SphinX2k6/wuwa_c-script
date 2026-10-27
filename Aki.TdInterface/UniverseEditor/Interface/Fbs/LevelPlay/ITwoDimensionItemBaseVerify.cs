using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045DD RID: 17885
	public static class ITwoDimensionItemBaseVerify
	{
		// Token: 0x0601B12A RID: 110890 RVA: 0x003DBA88 File Offset: 0x003D9C88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITwoDimensionItemBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITwoDimensionItemBaseVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079C6 RID: 31174
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013362 RID: 78690
			public static VerifyTableAction <0>__Verify;
		}
	}
}
