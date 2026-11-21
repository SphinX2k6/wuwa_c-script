using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589D RID: 22685
	public static class IGraph3dEffectComponentVerify
	{
		// Token: 0x06024CB5 RID: 150709 RVA: 0x0050D688 File Offset: 0x0050B888
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dEffectComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dEffectComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFireBoxFishEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083A2 RID: 33698
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014610 RID: 83472
			public static VerifyTableAction <0>__Verify;
		}
	}
}
