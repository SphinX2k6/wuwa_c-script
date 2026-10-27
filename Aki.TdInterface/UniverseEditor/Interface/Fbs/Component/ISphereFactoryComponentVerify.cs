using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597F RID: 22911
	public static class ISphereFactoryComponentVerify
	{
		// Token: 0x06026C94 RID: 158868 RVA: 0x00556B1C File Offset: 0x00554D1C
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

		// Token: 0x02007C36 RID: 31798
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013722 RID: 79650
			public static VerifyTableAction <0>__Verify;
		}
	}
}
