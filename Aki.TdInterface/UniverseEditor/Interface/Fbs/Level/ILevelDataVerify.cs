using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Entity;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004876 RID: 18550
	public static class ILevelDataVerify
	{
		// Token: 0x0601B6EA RID: 112362 RVA: 0x003E2031 File Offset: 0x003E0231
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081DD RID: 33245
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401437E RID: 82814
			public static VerifyTableAction <0>__Verify;
		}
	}
}
