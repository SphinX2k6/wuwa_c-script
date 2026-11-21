using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF9 RID: 24057
	public static class IRandomPoolChooseVerify
	{
		// Token: 0x0602828B RID: 164491 RVA: 0x0057E068 File Offset: 0x0057C268
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomPoolChooseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomPoolChooseVerify.<>O.<0>__Verify = new VerifyTableAction(IRandomPoolConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200846A RID: 33898
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401476A RID: 83818
			public static VerifyTableAction <0>__Verify;
		}
	}
}
