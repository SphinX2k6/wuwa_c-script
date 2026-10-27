using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ADA RID: 15066
	public static class ISystemVarConfigsVerify
	{
		// Token: 0x0601482A RID: 84010 RVA: 0x002FCA99 File Offset: 0x002FAC99
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISystemVarConfigsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemVarConfigsVerify.<>O.<0>__Verify = new VerifyTableAction(Record_ESystemModuleName_ISystemVarDefinesVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200787F RID: 30847
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E7 RID: 78055
			public static VerifyTableAction <0>__Verify;
		}
	}
}
