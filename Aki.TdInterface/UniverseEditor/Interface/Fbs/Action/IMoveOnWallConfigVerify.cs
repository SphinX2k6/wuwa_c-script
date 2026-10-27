using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4D RID: 27469
	public static class IMoveOnWallConfigVerify
	{
		// Token: 0x06030378 RID: 197496 RVA: 0x0068D541 File Offset: 0x0068B741
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMoveOnWallConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveOnWallConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DBA RID: 32186
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013958 RID: 80216
			public static VerifyTableAction <0>__Verify;
		}
	}
}
