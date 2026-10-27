using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C1 RID: 22209
	public static class IPasserbyNpcDeviceGradeConfigVerify
	{
		// Token: 0x0602518F RID: 151951 RVA: 0x0051F4E1 File Offset: 0x0051D6E1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcDeviceGradeConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcDeviceGradeConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcSpawnCountOverrideVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BC8 RID: 31688
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401367B RID: 79483
			public static VerifyTableAction <0>__Verify;
		}
	}
}
