using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747F RID: 29823
	public static class IPlayerMoveToPointVerify
	{
		// Token: 0x06034365 RID: 213861 RVA: 0x0070876C File Offset: 0x0070696C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayerMoveToPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayerMoveToPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200867F RID: 34431
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A6B RID: 84587
			public static VerifyTableAction <0>__Verify;
		}
	}
}
