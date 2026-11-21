using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9D RID: 27805
	public static class IEffectEntityPos2Verify
	{
		// Token: 0x0602FE93 RID: 196243 RVA: 0x00685B5C File Offset: 0x00683D5C
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

		// Token: 0x020085BD RID: 34237
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401496C RID: 84332
			public static VerifyTableAction <0>__Verify;
		}
	}
}
