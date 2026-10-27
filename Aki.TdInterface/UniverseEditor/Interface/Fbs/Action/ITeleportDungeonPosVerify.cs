using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007384 RID: 29572
	public static class ITeleportDungeonPosVerify
	{
		// Token: 0x06035AE8 RID: 219880 RVA: 0x0074F214 File Offset: 0x0074D414
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

		// Token: 0x02007E99 RID: 32409
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BD1 RID: 80849
			public static VerifyTableAction <0>__Verify;
		}
	}
}
