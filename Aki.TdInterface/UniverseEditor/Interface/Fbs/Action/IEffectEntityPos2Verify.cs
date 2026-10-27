using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200662C RID: 26156
	public static class IEffectEntityPos2Verify
	{
		// Token: 0x0602D6C2 RID: 186050 RVA: 0x00638FF4 File Offset: 0x006371F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEffectEntityPos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEffectEntityPos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D46 RID: 32070
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C0 RID: 80064
			public static VerifyTableAction <0>__Verify;
		}
	}
}
