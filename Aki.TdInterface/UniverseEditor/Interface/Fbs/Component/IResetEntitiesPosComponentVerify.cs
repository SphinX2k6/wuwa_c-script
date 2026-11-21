using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E6D RID: 24173
	public static class IResetEntitiesPosComponentVerify
	{
		// Token: 0x060286F5 RID: 165621 RVA: 0x00587654 File Offset: 0x00585854
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

		// Token: 0x0200847C RID: 33916
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014785 RID: 83845
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
