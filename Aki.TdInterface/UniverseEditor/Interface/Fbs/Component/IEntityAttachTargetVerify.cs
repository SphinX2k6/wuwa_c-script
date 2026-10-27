using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005155 RID: 20821
	public static class IEntityAttachTargetVerify
	{
		// Token: 0x060219C5 RID: 137669 RVA: 0x004AA1E8 File Offset: 0x004A83E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityAttachTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityAttachTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AF3 RID: 31475
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013512 RID: 79122
			public static VerifyTableAction <0>__Verify;
		}
	}
}
