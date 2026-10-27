using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BFD RID: 15357
	public static class ICircleRangeVerify
	{
		// Token: 0x06015238 RID: 86584 RVA: 0x00310044 File Offset: 0x0030E244
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICircleRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircleRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007899 RID: 30873
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013107 RID: 78087
			public static VerifyTableAction <0>__Verify;
		}
	}
}
