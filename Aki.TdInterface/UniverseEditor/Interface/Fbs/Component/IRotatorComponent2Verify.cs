using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005893 RID: 22675
	public static class IRotatorComponent2Verify
	{
		// Token: 0x060263A7 RID: 156583 RVA: 0x00545098 File Offset: 0x00543298
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRotatorComponent2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRotatorComponent2Verify.<>O.<0>__Verify = new VerifyTableAction(IStateRotationConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C15 RID: 31765
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136F0 RID: 79600
			public static VerifyTableAction <0>__Verify;
		}
	}
}
