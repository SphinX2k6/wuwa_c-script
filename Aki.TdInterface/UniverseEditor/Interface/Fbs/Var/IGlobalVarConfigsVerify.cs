using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E9D RID: 16029
	public static class IGlobalVarConfigsVerify
	{
		// Token: 0x06015A71 RID: 88689 RVA: 0x0031E875 File Offset: 0x0031CA75
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

		// Token: 0x020080BE RID: 32958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401413E RID: 82238
			public static VerifyTableAction <0>__Verify;
		}
	}
}
