using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716B RID: 29035
	public static class ISpawnVerify
	{
		// Token: 0x060337AD RID: 210861 RVA: 0x006EF640 File Offset: 0x006ED840
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

		// Token: 0x02007E68 RID: 32360
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A46 RID: 80454
			public static VerifyTableAction <0>__Verify;
		}
	}
}
