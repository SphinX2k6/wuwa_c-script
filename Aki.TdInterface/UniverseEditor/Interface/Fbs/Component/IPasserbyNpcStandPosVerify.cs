using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD4 RID: 23764
	public static class IPasserbyNpcStandPosVerify
	{
		// Token: 0x0602772C RID: 161580 RVA: 0x00566294 File Offset: 0x00564494
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcStandPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcStandPosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008438 RID: 33848
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401471F RID: 83743
			public static VerifyTableAction <0>__Verify;
		}
	}
}
