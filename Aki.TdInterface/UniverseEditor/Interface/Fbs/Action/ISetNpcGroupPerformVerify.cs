using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F9 RID: 30713
	public static class ISetNpcGroupPerformVerify
	{
		// Token: 0x06035F56 RID: 221014 RVA: 0x0073A63C File Offset: 0x0073883C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetNpcGroupPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcGroupPerformVerify.<>O.<0>__Verify = new VerifyUnionAction(TSetNpcGroupPerformTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086D8 RID: 34520
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ADF RID: 84703
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
