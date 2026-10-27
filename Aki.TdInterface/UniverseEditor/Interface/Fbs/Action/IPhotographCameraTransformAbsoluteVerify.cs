using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB9 RID: 27833
	public static class IPhotographCameraTransformAbsoluteVerify
	{
		// Token: 0x060310D2 RID: 200914 RVA: 0x006A8438 File Offset: 0x006A6638
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

		// Token: 0x02007DE9 RID: 32233
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401399B RID: 80283
			public static VerifyTableAction <0>__Verify;
		}
	}
}
