using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007937 RID: 31031
	public static class ISpawnVerify
	{
		// Token: 0x06036A57 RID: 223831 RVA: 0x0074FE4C File Offset: 0x0074E04C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpawnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnVerify.<>O.<0>__Verify = new VerifyTableAction(ITransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086FE RID: 34558
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B1B RID: 84763
			public static VerifyTableAction <0>__Verify;
		}
	}
}
