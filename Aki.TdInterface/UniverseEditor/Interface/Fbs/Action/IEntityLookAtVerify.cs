using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D60 RID: 28000
	public static class IEntityLookAtVerify
	{
		// Token: 0x060304D1 RID: 197841 RVA: 0x00690548 File Offset: 0x0068E748
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085CA RID: 34250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401497C RID: 84348
			public static VerifyTableAction <0>__Verify;
		}
	}
}
