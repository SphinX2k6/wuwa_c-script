using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A61 RID: 27233
	public static class ILookAtTargetVerify
	{
		// Token: 0x0602FB11 RID: 195345 RVA: 0x0067D8E0 File Offset: 0x0067BAE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILookAtTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILookAtTargetVerify.<>O.<0>__Verify = new VerifyTableAction(INpcLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DA0 RID: 32160
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013938 RID: 80184
			public static VerifyTableAction <0>__Verify;
		}
	}
}
