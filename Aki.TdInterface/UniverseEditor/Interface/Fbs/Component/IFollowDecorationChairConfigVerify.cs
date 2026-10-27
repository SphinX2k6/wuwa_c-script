using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200528D RID: 21133
	public static class IFollowDecorationChairConfigVerify
	{
		// Token: 0x06022705 RID: 141061 RVA: 0x004C6588 File Offset: 0x004C4788
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

		// Token: 0x02007B2A RID: 31530
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013566 RID: 79206
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
