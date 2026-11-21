using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4C RID: 27212
	public static class IClientGroupAiCommunicateVerify
	{
		// Token: 0x0602EADB RID: 191195 RVA: 0x0065CD90 File Offset: 0x0065AF90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientGroupAiCommunicateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientGroupAiCommunicateVerify.<>O.<0>__Verify = new VerifyUnionAction(TGroupAiCommunicateOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008594 RID: 34196
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014935 RID: 84277
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
