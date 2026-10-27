using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA8 RID: 23976
	public static class IEntityDirectionVerify
	{
		// Token: 0x06029099 RID: 168089 RVA: 0x005A2904 File Offset: 0x005A0B04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityDirectionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CA6 RID: 31910
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D3 RID: 79827
			public static VerifyTableAction <0>__Verify;
		}
	}
}
