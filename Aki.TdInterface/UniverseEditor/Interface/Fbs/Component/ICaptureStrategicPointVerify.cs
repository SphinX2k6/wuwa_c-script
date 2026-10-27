using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F54 RID: 20308
	public static class ICaptureStrategicPointVerify
	{
		// Token: 0x06020304 RID: 131844 RVA: 0x0047A9A4 File Offset: 0x00478BA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICaptureStrategicPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICaptureStrategicPointVerify.<>O.<0>__Verify = new VerifyTableAction(IStaticEntitiyMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A9C RID: 31388
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401347F RID: 78975
			public static VerifyTableAction <0>__Verify;
		}
	}
}
