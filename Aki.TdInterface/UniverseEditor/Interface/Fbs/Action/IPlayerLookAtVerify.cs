using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFE RID: 27902
	public static class IPlayerLookAtVerify
	{
		// Token: 0x0603133A RID: 201530 RVA: 0x006ACA90 File Offset: 0x006AAC90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayerLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayerLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DF2 RID: 32242
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A6 RID: 80294
			public static VerifyTableAction <0>__Verify;
		}
	}
}
