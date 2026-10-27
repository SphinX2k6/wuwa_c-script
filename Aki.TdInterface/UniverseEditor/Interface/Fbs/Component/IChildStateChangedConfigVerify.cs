using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F9F RID: 20383
	public static class IChildStateChangedConfigVerify
	{
		// Token: 0x060206A8 RID: 132776 RVA: 0x00482828 File Offset: 0x00480A28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildStateChangedConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildStateChangedConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDelayChangeStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AAE RID: 31406
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401349A RID: 79002
			public static VerifyTableAction <0>__Verify;
		}
	}
}
