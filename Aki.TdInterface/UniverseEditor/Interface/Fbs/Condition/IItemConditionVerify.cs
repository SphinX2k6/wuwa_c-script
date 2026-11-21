using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200513B RID: 20795
	public static class IItemConditionVerify
	{
		// Token: 0x06020B56 RID: 133974 RVA: 0x00488350 File Offset: 0x00486550
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IItemConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IItemConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082B3 RID: 33459
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014499 RID: 83097
			public static VerifyTableAction <0>__Verify;
		}
	}
}
