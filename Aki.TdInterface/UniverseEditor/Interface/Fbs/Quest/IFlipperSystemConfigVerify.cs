using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E68 RID: 15976
	public static class IFlipperSystemConfigVerify
	{
		// Token: 0x060167E5 RID: 92133 RVA: 0x003404FC File Offset: 0x0033E6FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlipperSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlipperSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFlipperSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078EA RID: 30954
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A2 RID: 78242
			public static VerifyTableAction <0>__Verify;
		}
	}
}
