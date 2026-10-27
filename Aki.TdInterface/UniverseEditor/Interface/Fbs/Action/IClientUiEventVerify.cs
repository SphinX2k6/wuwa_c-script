using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200640B RID: 25611
	public static class IClientUiEventVerify
	{
		// Token: 0x0602C50E RID: 181518 RVA: 0x006152D4 File Offset: 0x006134D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientUiEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientUiEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientEventUiVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D26 RID: 32038
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013894 RID: 80020
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
