using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A28 RID: 27176
	public static class IClientEventUiFlyingFlowerVerify
	{
		// Token: 0x0602E9E8 RID: 190952 RVA: 0x0065B3E0 File Offset: 0x006595E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientEventUiFlyingFlowerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientEventUiFlyingFlowerVerify.<>O.<0>__Verify = new VerifyTableAction(IClientEventFlyingFlowerUpdateSubtitleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008590 RID: 34192
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014931 RID: 84273
			public static VerifyTableAction <0>__Verify;
		}
	}
}
