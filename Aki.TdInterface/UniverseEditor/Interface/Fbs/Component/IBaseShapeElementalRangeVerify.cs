using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005423 RID: 21539
	public static class IBaseShapeElementalRangeVerify
	{
		// Token: 0x06021BEF RID: 138223 RVA: 0x004A7000 File Offset: 0x004A5200
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

		// Token: 0x020082DF RID: 33503
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144D9 RID: 83161
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
