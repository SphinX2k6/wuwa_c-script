using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B01 RID: 23297
	public static class IUndergroundStateInfoVerify
	{
		// Token: 0x06027C75 RID: 162933 RVA: 0x00578A40 File Offset: 0x00576C40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUndergroundStateInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUndergroundStateInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C72 RID: 31858
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013792 RID: 79762
			public static VerifyTableAction <0>__Verify;
		}
	}
}
