using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006028 RID: 24616
	public static class ISystemModuleDataSyncComponentVerify
	{
		// Token: 0x06029852 RID: 170066 RVA: 0x005AAAF4 File Offset: 0x005A8CF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISystemModuleDataSyncComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemModuleDataSyncComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemModuleDataSyncMotorRacingVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084BE RID: 33982
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147ED RID: 83949
			public static VerifyTableAction <0>__Verify;
		}
	}
}
