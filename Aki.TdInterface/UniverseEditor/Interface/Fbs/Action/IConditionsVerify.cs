using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2C RID: 27436
	public static class IConditionsVerify
	{
		// Token: 0x0602F351 RID: 193361 RVA: 0x006725E4 File Offset: 0x006707E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionsVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085A9 RID: 34217
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401494E RID: 84302
			public static VerifyTableAction <0>__Verify;
		}
	}
}
