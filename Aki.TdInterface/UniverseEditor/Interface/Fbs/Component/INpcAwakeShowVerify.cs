using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005619 RID: 22041
	public static class INpcAwakeShowVerify
	{
		// Token: 0x0602494A RID: 149834 RVA: 0x0050C150 File Offset: 0x0050A350
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcAwakeShowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcAwakeShowVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BA7 RID: 31655
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401363E RID: 79422
			public static VerifyTableAction <0>__Verify;
		}
	}
}
