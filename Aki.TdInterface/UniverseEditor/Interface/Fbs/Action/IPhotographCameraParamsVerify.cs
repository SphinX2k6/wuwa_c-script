using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB6 RID: 27830
	public static class IPhotographCameraParamsVerify
	{
		// Token: 0x060310B8 RID: 200888 RVA: 0x006A80BC File Offset: 0x006A62BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographCameraParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographCameraParamsVerify.<>O.<0>__Verify = new VerifyTableAction(IPhotographCameraTransformAbsoluteVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DE8 RID: 32232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401399A RID: 80282
			public static VerifyTableAction <0>__Verify;
		}
	}
}
