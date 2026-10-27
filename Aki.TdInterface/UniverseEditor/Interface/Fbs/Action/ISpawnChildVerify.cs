using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716E RID: 29038
	public static class ISpawnChildVerify
	{
		// Token: 0x060337C5 RID: 210885 RVA: 0x006EF904 File Offset: 0x006EDB04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpawnChildVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnChildVerify.<>O.<0>__Verify = new VerifyTableAction(ITransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E69 RID: 32361
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A47 RID: 80455
			public static VerifyTableAction <0>__Verify;
		}
	}
}
