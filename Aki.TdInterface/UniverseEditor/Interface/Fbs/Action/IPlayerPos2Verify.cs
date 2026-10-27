using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0D RID: 27917
	public static class IPlayerPos2Verify
	{
		// Token: 0x060313AB RID: 201643 RVA: 0x006AD7D8 File Offset: 0x006AB9D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayerPos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayerPos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DF5 RID: 32245
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A9 RID: 80297
			public static VerifyTableAction <0>__Verify;
		}
	}
}
