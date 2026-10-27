using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5B RID: 27227
	public static class ILookAtBubbleEntityConfigVerify
	{
		// Token: 0x0602FADB RID: 195291 RVA: 0x0067D284 File Offset: 0x0067B484
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILookAtBubbleEntityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILookAtBubbleEntityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityLookAtPerformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D9F RID: 32159
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013937 RID: 80183
			public static VerifyTableAction <0>__Verify;
		}
	}
}
