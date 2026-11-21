using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F8C RID: 24460
	public static class ISphereFactoryComponentVerify
	{
		// Token: 0x060291FE RID: 168446 RVA: 0x0059D788 File Offset: 0x0059B988
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISphereFactoryComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISphereFactoryComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084A5 RID: 33957
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147C4 RID: 83908
			public static VerifyTableAction <0>__Verify;
		}
	}
}
