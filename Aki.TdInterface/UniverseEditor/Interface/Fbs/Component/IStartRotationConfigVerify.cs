using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA7 RID: 24487
	public static class IStartRotationConfigVerify
	{
		// Token: 0x060292FD RID: 168701 RVA: 0x0059F788 File Offset: 0x0059D988
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStartRotationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStartRotationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084A9 RID: 33961
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147C8 RID: 83912
			public static VerifyTableAction <0>__Verify;
		}
	}
}
