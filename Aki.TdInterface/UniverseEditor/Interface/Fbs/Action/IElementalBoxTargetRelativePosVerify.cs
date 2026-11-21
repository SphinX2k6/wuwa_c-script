using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAC RID: 27820
	public static class IElementalBoxTargetRelativePosVerify
	{
		// Token: 0x0602FEFD RID: 196349 RVA: 0x00686648 File Offset: 0x00684848
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IElementalBoxTargetRelativePosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalBoxTargetRelativePosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085BF RID: 34239
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401496E RID: 84334
			public static VerifyTableAction <0>__Verify;
		}
	}
}
