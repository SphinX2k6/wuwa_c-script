using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAD RID: 27821
	public static class IPhoneSystemInteractVerify
	{
		// Token: 0x0603107A RID: 200826 RVA: 0x006A7A60 File Offset: 0x006A5C60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPhoneSystemInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhoneSystemInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TPhoneSystemInteractVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DE7 RID: 32231
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013999 RID: 80281
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
