using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004384 RID: 17284
	public static class IMotorFightSystemConfigVerify
	{
		// Token: 0x060186CE RID: 100046 RVA: 0x0037B4CC File Offset: 0x003796CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorFightSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorFightSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorFightSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008151 RID: 33105
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014240 RID: 82496
			public static VerifyTableAction <0>__Verify;
		}
	}
}
