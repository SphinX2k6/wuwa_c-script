using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742F RID: 29743
	public static class IPhotographCameraTransformAbsoluteVerify
	{
		// Token: 0x060340A9 RID: 213161 RVA: 0x0070366C File Offset: 0x0070186C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographCameraTransformAbsoluteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographCameraTransformAbsoluteVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPhotographCameraTransformAbsoluteVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IPhotographCameraTransformAbsoluteVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008674 RID: 34420
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A5E RID: 84574
			public static VerifyTableAction <0>__Verify;
		}
	}
}
