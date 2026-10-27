using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FEE RID: 28654
	public static class ISetExploreStateVerify
	{
		// Token: 0x06032AAD RID: 207533 RVA: 0x006D5D15 File Offset: 0x006D3F15
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetExploreStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetExploreStateVerify.<>O.<0>__Verify = new VerifyTableAction(ITeleControlConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E39 RID: 32313
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F9 RID: 80377
			public static VerifyTableAction <0>__Verify;
		}
	}
}
