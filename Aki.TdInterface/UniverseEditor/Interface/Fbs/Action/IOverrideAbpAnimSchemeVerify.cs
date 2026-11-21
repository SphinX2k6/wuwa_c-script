using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B7 RID: 29623
	public static class IOverrideAbpAnimSchemeVerify
	{
		// Token: 0x06033CFF RID: 212223 RVA: 0x006FD249 File Offset: 0x006FB449
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOverrideAbpAnimSchemeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOverrideAbpAnimSchemeVerify.<>O.<0>__Verify = new VerifyTableAction(IOverrideAbpAnimSchemeConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200866A RID: 34410
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A53 RID: 84563
			public static VerifyTableAction <0>__Verify;
		}
	}
}
