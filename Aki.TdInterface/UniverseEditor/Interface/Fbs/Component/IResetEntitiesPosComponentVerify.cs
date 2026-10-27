using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005860 RID: 22624
	public static class IResetEntitiesPosComponentVerify
	{
		// Token: 0x06026193 RID: 156051 RVA: 0x00540B08 File Offset: 0x0053ED08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IResetEntitiesPosComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetEntitiesPosComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C0D RID: 31757
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136E3 RID: 79587
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
