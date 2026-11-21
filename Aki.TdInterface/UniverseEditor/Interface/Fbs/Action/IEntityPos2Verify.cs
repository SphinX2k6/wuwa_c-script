using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D69 RID: 28009
	public static class IEntityPos2Verify
	{
		// Token: 0x0603052F RID: 197935 RVA: 0x0069114C File Offset: 0x0068F34C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085CD RID: 34253
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014980 RID: 84352
			public static VerifyTableAction <0>__Verify;
		}
	}
}
