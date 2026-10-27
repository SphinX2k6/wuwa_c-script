using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BC RID: 21948
	public static class IMotorHookEndDirVerify
	{
		// Token: 0x060245C6 RID: 148934 RVA: 0x00505058 File Offset: 0x00503258
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorHookEndDirVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorHookEndDirVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B99 RID: 31641
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401362C RID: 79404
			public static VerifyTableAction <0>__Verify;
		}
	}
}
