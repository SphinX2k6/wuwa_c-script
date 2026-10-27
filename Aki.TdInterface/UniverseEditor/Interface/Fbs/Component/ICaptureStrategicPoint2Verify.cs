using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F57 RID: 20311
	public static class ICaptureStrategicPoint2Verify
	{
		// Token: 0x0602033A RID: 131898 RVA: 0x0047B0FC File Offset: 0x004792FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICaptureStrategicPoint2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICaptureStrategicPoint2Verify.<>O.<0>__Verify = new VerifyTableAction(IStaticEntitiyMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A9D RID: 31389
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013480 RID: 78976
			public static VerifyTableAction <0>__Verify;
		}
	}
}
