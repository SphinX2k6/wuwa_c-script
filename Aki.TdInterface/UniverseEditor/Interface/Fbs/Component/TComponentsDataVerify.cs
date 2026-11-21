using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006218 RID: 25112
	public static class TComponentsDataVerify
	{
		// Token: 0x0602AC44 RID: 175172 RVA: 0x005D78E5 File Offset: 0x005D5AE5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = TComponentsDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TComponentsDataVerify.<>O.<0>__Verify = new VerifyTableAction(TComponentDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008500 RID: 34048
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014860 RID: 84064
			public static VerifyTableAction <0>__Verify;
		}
	}
}
