using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B6B RID: 31595
	public static class ITeleportDungeonPosVerify
	{
		// Token: 0x06038E83 RID: 233091 RVA: 0x007B1754 File Offset: 0x007AF954
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportDungeonPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportDungeonPosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008732 RID: 34610
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CAA RID: 85162
			public static VerifyTableAction <0>__Verify;
		}
	}
}
