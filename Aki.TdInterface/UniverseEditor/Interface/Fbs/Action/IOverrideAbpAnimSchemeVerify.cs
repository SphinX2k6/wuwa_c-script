using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C50 RID: 27728
	public static class IOverrideAbpAnimSchemeVerify
	{
		// Token: 0x06030DA4 RID: 200100 RVA: 0x006A2D49 File Offset: 0x006A0F49
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

		// Token: 0x02007DE0 RID: 32224
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013991 RID: 80273
			public static VerifyTableAction <0>__Verify;
		}
	}
}
