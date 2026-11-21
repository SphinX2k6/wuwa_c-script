using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C65 RID: 23653
	public static class IPasserbyNpcDeviceGradeConfigVerify
	{
		// Token: 0x060273E4 RID: 160740 RVA: 0x00560429 File Offset: 0x0055E629
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

		// Token: 0x0200842B RID: 33835
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401470B RID: 83723
			public static VerifyTableAction <0>__Verify;
		}
	}
}
