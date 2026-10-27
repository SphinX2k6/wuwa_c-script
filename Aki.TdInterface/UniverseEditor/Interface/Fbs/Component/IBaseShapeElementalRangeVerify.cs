using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF1 RID: 20209
	public static class IBaseShapeElementalRangeVerify
	{
		// Token: 0x0601FE7F RID: 130687 RVA: 0x00470C6C File Offset: 0x0046EE6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBaseShapeElementalRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBaseShapeElementalRangeVerify.<>O.<0>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A88 RID: 31368
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013462 RID: 78946
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
