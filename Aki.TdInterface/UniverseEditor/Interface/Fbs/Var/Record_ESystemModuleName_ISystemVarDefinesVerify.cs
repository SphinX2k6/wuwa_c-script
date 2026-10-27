using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B46 RID: 15174
	public static class Record_ESystemModuleName_ISystemVarDefinesVerify
	{
		// Token: 0x06014BE4 RID: 84964 RVA: 0x00303EB0 File Offset: 0x003020B0
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

		// Token: 0x02007887 RID: 30855
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F0 RID: 78064
			public static VerifyTableAction <0>__Verify;
		}
	}
}
