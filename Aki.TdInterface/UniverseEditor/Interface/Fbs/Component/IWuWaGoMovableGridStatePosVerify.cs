using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCC RID: 23500
	public static class IWuWaGoMovableGridStatePosVerify
	{
		// Token: 0x06028424 RID: 164900 RVA: 0x00588010 File Offset: 0x00586210
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoMovableGridStatePosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoMovableGridStatePosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C8A RID: 31882
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B5 RID: 79797
			public static VerifyTableAction <0>__Verify;
		}
	}
}
