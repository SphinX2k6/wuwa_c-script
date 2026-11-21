using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA0 RID: 27808
	public static class IEffectPlayerPos2Verify
	{
		// Token: 0x0602FEAF RID: 196271 RVA: 0x00685EBC File Offset: 0x006840BC
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

		// Token: 0x020085BE RID: 34238
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401496D RID: 84333
			public static VerifyTableAction <0>__Verify;
		}
	}
}
