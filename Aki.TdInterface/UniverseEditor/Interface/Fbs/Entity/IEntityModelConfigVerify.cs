using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B6 RID: 18358
	public static class IEntityModelConfigVerify
	{
		// Token: 0x0601C56A RID: 116074 RVA: 0x00402CE9 File Offset: 0x00400EE9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityModelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityModelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityModelVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079FA RID: 31226
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A8 RID: 78760
			public static VerifyTableAction <0>__Verify;
		}
	}
}
