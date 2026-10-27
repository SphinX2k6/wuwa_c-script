using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B26 RID: 27430
	public static class IMotorParkourTrackingEventVerify
	{
		// Token: 0x0603025C RID: 197212 RVA: 0x0068B638 File Offset: 0x00689838
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

		// Token: 0x02007DB5 RID: 32181
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013953 RID: 80211
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
