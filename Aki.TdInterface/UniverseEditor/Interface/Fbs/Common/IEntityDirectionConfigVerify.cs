using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E8 RID: 25576
	public static class IEntityDirectionConfigVerify
	{
		// Token: 0x0602B73F RID: 177983 RVA: 0x005EB9E0 File Offset: 0x005E9BE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityDirectionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityDirectionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDirectionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008518 RID: 34072
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401487A RID: 84090
			public static VerifyTableAction <0>__Verify;
		}
	}
}
