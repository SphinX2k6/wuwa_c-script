using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007488 RID: 29832
	public static class IPlayerPos2Verify
	{
		// Token: 0x0603439F RID: 213919 RVA: 0x00708D08 File Offset: 0x00706F08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayerPos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayerPos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008680 RID: 34432
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A6C RID: 84588
			public static VerifyTableAction <0>__Verify;
		}
	}
}
