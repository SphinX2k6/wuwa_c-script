using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C4 RID: 25796
	public static class IConeRangeCheckVerify
	{
		// Token: 0x0602CBEB RID: 183275 RVA: 0x00626858 File Offset: 0x00624A58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConeRangeCheckVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConeRangeCheckVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D35 RID: 32053
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A4 RID: 80036
			public static VerifyTableAction <0>__Verify;
		}
	}
}
