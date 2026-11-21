using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006079 RID: 24697
	public static class IThrowMotionFreeFallVerify
	{
		// Token: 0x06029BC6 RID: 170950 RVA: 0x005B2C28 File Offset: 0x005B0E28
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

		// Token: 0x020084CA RID: 33994
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401480E RID: 83982
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401480F RID: 83983
			public static VerifyTableAction <1>__Verify;
		}
	}
}
