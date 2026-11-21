using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A45 RID: 19013
	public static class ITwoDimensionItemBaseVerify
	{
		// Token: 0x0601C8FF RID: 116991 RVA: 0x00407D24 File Offset: 0x00405F24
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

		// Token: 0x0200820F RID: 33295
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143C9 RID: 82889
			public static VerifyTableAction <0>__Verify;
		}
	}
}
