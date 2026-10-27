using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679A RID: 26522
	public static class IFailurePoseInteractVerify
	{
		// Token: 0x0602E26B RID: 189035 RVA: 0x0064DBBC File Offset: 0x0064BDBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFailurePoseInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFailurePoseInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D69 RID: 32105
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138EB RID: 80107
			public static VerifyTableAction <0>__Verify;
		}
	}
}
