using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725D RID: 29277
	public static class IMotorParkourTrackingEventVerify
	{
		// Token: 0x06033030 RID: 208944 RVA: 0x006E2CF0 File Offset: 0x006E0EF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMotorParkourTrackingEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorParkourTrackingEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200863C RID: 34364
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A11 RID: 84497
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
