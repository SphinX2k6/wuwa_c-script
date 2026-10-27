using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F16 RID: 16150
	public static class ILogicProgramSpecialProcessVerify
	{
		// Token: 0x06016ED9 RID: 93913 RVA: 0x0034F211 File Offset: 0x0034D411
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILogicProgramSpecialProcessVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILogicProgramSpecialProcessVerify.<>O.<0>__Verify = new VerifyTableAction(IDisableUroVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007907 RID: 30983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131DA RID: 78298
			public static VerifyTableAction <0>__Verify;
		}
	}
}
