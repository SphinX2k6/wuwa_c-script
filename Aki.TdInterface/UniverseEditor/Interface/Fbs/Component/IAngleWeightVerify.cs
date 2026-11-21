using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C9 RID: 21449
	public static class IAngleWeightVerify
	{
		// Token: 0x060217DA RID: 137178 RVA: 0x0049E700 File Offset: 0x0049C900
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

		// Token: 0x020082D1 RID: 33489
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144C0 RID: 83136
			public static VerifyTableAction <0>__Verify;
		}
	}
}
