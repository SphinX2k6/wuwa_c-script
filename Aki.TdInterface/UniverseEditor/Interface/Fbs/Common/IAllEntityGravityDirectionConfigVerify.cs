using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D12 RID: 23826
	public static class IAllEntityGravityDirectionConfigVerify
	{
		// Token: 0x06028B3C RID: 166716 RVA: 0x00597401 File Offset: 0x00595601
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

		// Token: 0x02007C92 RID: 31890
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137BF RID: 79807
			public static VerifyTableAction <0>__Verify;
		}
	}
}
