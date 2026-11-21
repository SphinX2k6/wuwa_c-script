using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D6F RID: 23919
	public static class IPointLightOperationsVerify
	{
		// Token: 0x06027D1A RID: 163098 RVA: 0x0057267C File Offset: 0x0057087C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPointLightOperationsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPointLightOperationsVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200844C RID: 33868
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014742 RID: 83778
			public static VerifyTableAction <0>__Verify;
		}
	}
}
