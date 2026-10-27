using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051AC RID: 20908
	public static class IEntityPackageNodeVerify
	{
		// Token: 0x06021D7A RID: 138618 RVA: 0x004B1C34 File Offset: 0x004AFE34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPackageNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPackageNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPackageNodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B01 RID: 31489
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013525 RID: 79141
			public static VerifyTableAction <0>__Verify;
		}
	}
}
