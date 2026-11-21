using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC1 RID: 19393
	public static class IFixProcessorVerify
	{
		// Token: 0x0601D9A3 RID: 121251 RVA: 0x00427D6D File Offset: 0x00425F6D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixProcessorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixProcessorVerify.<>O.<0>__Verify = new VerifyTableAction(IFixActionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008233 RID: 33331
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143FD RID: 82941
			public static VerifyTableAction <0>__Verify;
		}
	}
}
