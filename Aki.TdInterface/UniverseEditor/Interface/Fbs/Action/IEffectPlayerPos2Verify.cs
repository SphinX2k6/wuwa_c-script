using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200662F RID: 26159
	public static class IEffectPlayerPos2Verify
	{
		// Token: 0x0602D6DE RID: 186078 RVA: 0x00639354 File Offset: 0x00637554
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEffectPlayerPos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEffectPlayerPos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D47 RID: 32071
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C1 RID: 80065
			public static VerifyTableAction <0>__Verify;
		}
	}
}
