using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007500 RID: 29952
	public static class IPostProcessVolumeCenterPositionVerify
	{
		// Token: 0x0603486B RID: 215147 RVA: 0x00712108 File Offset: 0x00710308
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPostProcessVolumeCenterPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPostProcessVolumeCenterPositionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200868F RID: 34447
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A82 RID: 84610
			public static VerifyTableAction <0>__Verify;
		}
	}
}
