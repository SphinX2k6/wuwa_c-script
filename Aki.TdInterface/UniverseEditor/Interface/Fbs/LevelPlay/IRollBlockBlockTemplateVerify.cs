using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049BE RID: 18878
	public static class IRollBlockBlockTemplateVerify
	{
		// Token: 0x0601C34D RID: 115533 RVA: 0x003FB6A8 File Offset: 0x003F98A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockBlockTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockBlockTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081FE RID: 33278
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143B7 RID: 82871
			public static VerifyTableAction <0>__Verify;
		}
	}
}
