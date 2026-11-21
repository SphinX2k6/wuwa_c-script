using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005738 RID: 22328
	public static class IExhibitEffectVerify
	{
		// Token: 0x06023EDB RID: 147163 RVA: 0x004F0684 File Offset: 0x004EE884
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExhibitEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExhibitEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008367 RID: 33639
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B5 RID: 83381
			public static VerifyTableAction <0>__Verify;
		}
	}
}
