using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BAC RID: 19372
	public static class IMontagesConfigVerify
	{
		// Token: 0x0601D90D RID: 121101 RVA: 0x00426879 File Offset: 0x00424A79
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontagesConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontagesConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200822E RID: 33326
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143F5 RID: 82933
			public static VerifyTableAction <0>__Verify;
		}
	}
}
