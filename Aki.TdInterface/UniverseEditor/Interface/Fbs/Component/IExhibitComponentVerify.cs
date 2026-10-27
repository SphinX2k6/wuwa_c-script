using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D0 RID: 20944
	public static class IExhibitComponentVerify
	{
		// Token: 0x06021F67 RID: 139111 RVA: 0x004B62AC File Offset: 0x004B44AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExhibitComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExhibitComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TExhibitConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B0C RID: 31500
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013536 RID: 79158
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
