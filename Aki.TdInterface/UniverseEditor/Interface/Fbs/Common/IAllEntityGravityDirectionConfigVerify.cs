using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006346 RID: 25414
	public static class IAllEntityGravityDirectionConfigVerify
	{
		// Token: 0x0602B190 RID: 176528 RVA: 0x005DFC71 File Offset: 0x005DDE71
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAllEntityGravityDirectionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAllEntityGravityDirectionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDirectionConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008503 RID: 34051
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014865 RID: 84069
			public static VerifyTableAction <0>__Verify;
		}
	}
}
