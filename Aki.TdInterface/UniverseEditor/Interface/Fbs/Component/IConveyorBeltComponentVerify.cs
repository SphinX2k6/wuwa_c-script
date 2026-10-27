using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200502C RID: 20524
	public static class IConveyorBeltComponentVerify
	{
		// Token: 0x06020E2C RID: 134700 RVA: 0x00492BF8 File Offset: 0x00490DF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConveyorBeltComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConveyorBeltComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConveyorBeltStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007ACB RID: 31435
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134C8 RID: 79048
			public static VerifyTableAction <0>__Verify;
		}
	}
}
