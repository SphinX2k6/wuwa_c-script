using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA0 RID: 20128
	public static class IAngleWeightVerify
	{
		// Token: 0x0601FAE5 RID: 129765 RVA: 0x0046949C File Offset: 0x0046769C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAngleWeightVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAngleWeightVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityAngleWeightVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A7D RID: 31357
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401344D RID: 78925
			public static VerifyTableAction <0>__Verify;
		}
	}
}
