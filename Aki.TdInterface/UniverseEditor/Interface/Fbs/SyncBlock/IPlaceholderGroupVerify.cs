using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F85 RID: 16261
	public static class IPlaceholderGroupVerify
	{
		// Token: 0x06016288 RID: 90760 RVA: 0x0032D98C File Offset: 0x0032BB8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlaceholderGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlaceholderGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IPlaceholderVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080CE RID: 32974
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401414F RID: 82255
			public static VerifyTableAction <0>__Verify;
		}
	}
}
