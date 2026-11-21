using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B36 RID: 23350
	public static class IMonsterPerformConfigVerify
	{
		// Token: 0x06026671 RID: 157297 RVA: 0x00542799 File Offset: 0x00540999
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterPerformConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterPerformConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterShowOnDeathEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083F7 RID: 33783
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146B1 RID: 83633
			public static VerifyTableAction <0>__Verify;
		}
	}
}
