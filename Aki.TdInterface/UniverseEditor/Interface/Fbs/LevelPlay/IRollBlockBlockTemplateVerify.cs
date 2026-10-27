using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004556 RID: 17750
	public static class IRollBlockBlockTemplateVerify
	{
		// Token: 0x0601AB78 RID: 109432 RVA: 0x003CF40C File Offset: 0x003CD60C
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

		// Token: 0x020079B5 RID: 31157
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013350 RID: 78672
			public static VerifyTableAction <0>__Verify;
		}
	}
}
