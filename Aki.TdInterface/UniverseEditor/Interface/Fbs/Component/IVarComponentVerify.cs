using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B07 RID: 23303
	public static class IVarComponentVerify
	{
		// Token: 0x06027CAB RID: 162987 RVA: 0x0057906C File Offset: 0x0057726C
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

		// Token: 0x02007C73 RID: 31859
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013793 RID: 79763
			public static VerifyTableAction <0>__Verify;
		}
	}
}
