using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F48 RID: 16200
	public static class Record_ESystemModuleName_ISystemVarDefinesVerify
	{
		// Token: 0x0601608E RID: 90254 RVA: 0x0032A140 File Offset: 0x00328340
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_ESystemModuleName_ISystemVarDefinesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_ESystemModuleName_ISystemVarDefinesVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemVarDefineVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080CA RID: 32970
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401414B RID: 82251
			public static VerifyTableAction <0>__Verify;
		}
	}
}
