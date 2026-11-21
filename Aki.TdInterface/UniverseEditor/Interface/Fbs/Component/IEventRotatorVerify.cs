using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572F RID: 22319
	public static class IEventRotatorVerify
	{
		// Token: 0x06023E7D RID: 147069 RVA: 0x004EFA50 File Offset: 0x004EDC50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEventRotatorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEventRotatorVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEventRotatorVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IEventRotatorVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008364 RID: 33636
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B2 RID: 83378
			public static VerifyTableAction <0>__Verify;
		}
	}
}
