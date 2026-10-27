using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFF RID: 27647
	public static class IOpenGiantDeliveryWithReturnVerify
	{
		// Token: 0x060309AB RID: 199083 RVA: 0x006990E8 File Offset: 0x006972E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenGiantDeliveryWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenGiantDeliveryWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DD0 RID: 32208
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013974 RID: 80244
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
