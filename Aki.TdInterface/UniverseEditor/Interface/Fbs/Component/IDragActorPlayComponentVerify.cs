using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B6 RID: 20662
	public static class IDragActorPlayComponentVerify
	{
		// Token: 0x06021340 RID: 136000 RVA: 0x0049CDCC File Offset: 0x0049AFCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDragActorPlayComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDragActorPlayComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDragActorPlayConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007ADD RID: 31453
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134EA RID: 79082
			public static VerifyTableAction <0>__Verify;
		}
	}
}
