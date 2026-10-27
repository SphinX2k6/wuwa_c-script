using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A6 RID: 20902
	public static class IEntityPackageComponentVerify
	{
		// Token: 0x06021D36 RID: 138550 RVA: 0x004B1334 File Offset: 0x004AF534
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPackageComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPackageComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPackageDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AFF RID: 31487
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013523 RID: 79139
			public static VerifyTableAction <0>__Verify;
		}
	}
}
