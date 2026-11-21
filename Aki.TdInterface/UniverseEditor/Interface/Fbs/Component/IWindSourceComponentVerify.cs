using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200619E RID: 24990
	public static class IWindSourceComponentVerify
	{
		// Token: 0x0602A792 RID: 173970 RVA: 0x005CB1AC File Offset: 0x005C93AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWindSourceComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWindSourceComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IWindDirectionalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084F2 RID: 34034
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014851 RID: 84049
			public static VerifyTableAction <0>__Verify;
		}
	}
}
