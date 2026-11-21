using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005516 RID: 21782
	public static class ICollisionChannelConfigVerify
	{
		// Token: 0x060226CE RID: 141006 RVA: 0x004BE639 File Offset: 0x004BC839
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

		// Token: 0x0200830F RID: 33551
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014521 RID: 83233
			public static VerifyTableAction <0>__Verify;
		}
	}
}
