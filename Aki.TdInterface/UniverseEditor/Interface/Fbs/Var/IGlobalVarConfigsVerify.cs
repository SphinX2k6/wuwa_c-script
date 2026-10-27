using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A9B RID: 15003
	public static class IGlobalVarConfigsVerify
	{
		// Token: 0x060145CB RID: 83403 RVA: 0x002F8669 File Offset: 0x002F6869
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGlobalVarConfigsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGlobalVarConfigsVerify.<>O.<0>__Verify = new VerifyTableAction(IVarDefineVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200787B RID: 30843
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E3 RID: 78051
			public static VerifyTableAction <0>__Verify;
		}
	}
}
