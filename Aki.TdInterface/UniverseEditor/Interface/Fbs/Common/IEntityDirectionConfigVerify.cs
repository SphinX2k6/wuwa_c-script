using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DAB RID: 23979
	public static class IEntityDirectionConfigVerify
	{
		// Token: 0x060290B5 RID: 168117 RVA: 0x005A2CB0 File Offset: 0x005A0EB0
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

		// Token: 0x02007CA7 RID: 31911
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D4 RID: 79828
			public static VerifyTableAction <0>__Verify;
		}
	}
}
