using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200611D RID: 24861
	public static class IVarComponentVerify
	{
		// Token: 0x0602A26F RID: 172655 RVA: 0x005C0AC0 File Offset: 0x005BECC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVarComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVarComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVarDefineVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084E4 RID: 34020
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014839 RID: 84025
			public static VerifyTableAction <0>__Verify;
		}
	}
}
