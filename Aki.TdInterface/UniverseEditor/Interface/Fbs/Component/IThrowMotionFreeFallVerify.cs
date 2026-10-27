using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6C RID: 23148
	public static class IThrowMotionFreeFallVerify
	{
		// Token: 0x0602764E RID: 161358 RVA: 0x0056BC1C File Offset: 0x00569E1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IThrowMotionFreeFallVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IThrowMotionFreeFallVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IThrowMotionFreeFallVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IThrowMotionFreeFallVerify.<>O.<1>__Verify = new VerifyTableAction(IAngularVelocityConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C5B RID: 31835
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401376A RID: 79722
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401376B RID: 79723
			public static VerifyTableAction <1>__Verify;
		}
	}
}
