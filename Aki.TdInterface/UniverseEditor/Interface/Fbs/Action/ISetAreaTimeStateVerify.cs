using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAD RID: 28589
	public static class ISetAreaTimeStateVerify
	{
		// Token: 0x06032870 RID: 206960 RVA: 0x006D1AB4 File Offset: 0x006CFCB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetAreaTimeStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAreaTimeStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TSetAreaTimeTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E2F RID: 32303
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139ED RID: 80365
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
