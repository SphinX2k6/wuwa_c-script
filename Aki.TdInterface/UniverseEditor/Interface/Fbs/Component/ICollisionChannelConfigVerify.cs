using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FBA RID: 20410
	public static class ICollisionChannelConfigVerify
	{
		// Token: 0x060207DA RID: 133082 RVA: 0x00485155 File Offset: 0x00483355
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICollisionChannelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICollisionChannelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IOverrideCollisionChannelVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AB5 RID: 31413
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134A3 RID: 79011
			public static VerifyTableAction <0>__Verify;
		}
	}
}
