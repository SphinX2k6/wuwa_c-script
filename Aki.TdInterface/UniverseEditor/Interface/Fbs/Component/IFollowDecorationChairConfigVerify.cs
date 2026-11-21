using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F5 RID: 22517
	public static class IFollowDecorationChairConfigVerify
	{
		// Token: 0x0602469F RID: 149151 RVA: 0x005010F8 File Offset: 0x004FF2F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFollowDecorationChairConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowDecorationChairConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008385 RID: 33669
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145E6 RID: 83430
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
