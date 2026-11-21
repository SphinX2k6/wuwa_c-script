using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C1E RID: 19486
	public static class IEntityModelConfigVerify
	{
		// Token: 0x0601DD3F RID: 122175 RVA: 0x0042EF85 File Offset: 0x0042D185
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

		// Token: 0x02008243 RID: 33347
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401440F RID: 82959
			public static VerifyTableAction <0>__Verify;
		}
	}
}
