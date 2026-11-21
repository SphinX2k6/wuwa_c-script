using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EDC RID: 16092
	public static class ISystemVarConfigsVerify
	{
		// Token: 0x06015CD4 RID: 89300 RVA: 0x00322D29 File Offset: 0x00320F29
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

		// Token: 0x020080C2 RID: 32962
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014142 RID: 82242
			public static VerifyTableAction <0>__Verify;
		}
	}
}
