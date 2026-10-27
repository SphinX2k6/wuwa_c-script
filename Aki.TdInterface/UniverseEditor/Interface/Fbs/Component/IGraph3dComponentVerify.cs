using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005308 RID: 21256
	public static class IGraph3dComponentVerify
	{
		// Token: 0x06022B91 RID: 142225 RVA: 0x004CFC8C File Offset: 0x004CDE8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IGraph3dNormalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B42 RID: 31554
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401358A RID: 79242
			public static VerifyTableAction <0>__Verify;
		}
	}
}
