using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200506E RID: 20590
	public static class ICylinderVerify
	{
		// Token: 0x06021006 RID: 135174 RVA: 0x00495D18 File Offset: 0x00493F18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICylinderVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICylinderVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AD0 RID: 31440
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134CF RID: 79055
			public static VerifyTableAction <0>__Verify;
		}
	}
}
