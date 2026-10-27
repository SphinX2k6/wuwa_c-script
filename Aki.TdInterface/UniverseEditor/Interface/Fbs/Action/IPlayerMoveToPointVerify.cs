using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D04 RID: 27908
	public static class IPlayerMoveToPointVerify
	{
		// Token: 0x06031371 RID: 201585 RVA: 0x006AD23C File Offset: 0x006AB43C
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

		// Token: 0x02007DF4 RID: 32244
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A8 RID: 80296
			public static VerifyTableAction <0>__Verify;
		}
	}
}
