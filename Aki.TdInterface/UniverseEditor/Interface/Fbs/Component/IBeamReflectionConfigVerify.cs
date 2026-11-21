using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005447 RID: 21575
	public static class IBeamReflectionConfigVerify
	{
		// Token: 0x06021D97 RID: 138647 RVA: 0x004AAA2D File Offset: 0x004A8C2D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBeamReflectionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBeamReflectionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082E6 RID: 33510
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144E5 RID: 83173
			public static VerifyTableAction <0>__Verify;
		}
	}
}
