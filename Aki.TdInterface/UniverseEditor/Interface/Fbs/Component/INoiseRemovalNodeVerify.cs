using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA8 RID: 23464
	public static class INoiseRemovalNodeVerify
	{
		// Token: 0x06026AF0 RID: 158448 RVA: 0x0054BC78 File Offset: 0x00549E78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INoiseRemovalNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INoiseRemovalNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008407 RID: 33799
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146CB RID: 83659
			public static VerifyTableAction <0>__Verify;
		}
	}
}
