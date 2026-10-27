using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051CA RID: 20938
	public static class IEventRotatorVerify
	{
		// Token: 0x06021F25 RID: 139045 RVA: 0x004B59E8 File Offset: 0x004B3BE8
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

		// Token: 0x02007B0A RID: 31498
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013534 RID: 79156
			public static VerifyTableAction <0>__Verify;
		}
	}
}
