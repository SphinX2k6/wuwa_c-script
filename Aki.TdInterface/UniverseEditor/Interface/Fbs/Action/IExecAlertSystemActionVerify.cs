using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F8 RID: 26360
	public static class IExecAlertSystemActionVerify
	{
		// Token: 0x0602DD83 RID: 187779 RVA: 0x00644EA0 File Offset: 0x006430A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExecAlertSystemActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecAlertSystemActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TAlertSystemOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D59 RID: 32089
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D7 RID: 80087
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
