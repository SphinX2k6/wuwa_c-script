using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EA0 RID: 24224
	public static class IRotatorComponent2Verify
	{
		// Token: 0x06028909 RID: 166153 RVA: 0x0058BBE4 File Offset: 0x00589DE4
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

		// Token: 0x02008484 RID: 33924
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014792 RID: 83858
			public static VerifyTableAction <0>__Verify;
		}
	}
}
