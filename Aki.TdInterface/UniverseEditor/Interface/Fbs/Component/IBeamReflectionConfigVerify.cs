using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F15 RID: 20245
	public static class IBeamReflectionConfigVerify
	{
		// Token: 0x06020027 RID: 131111 RVA: 0x00474699 File Offset: 0x00472899
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

		// Token: 0x02007A8F RID: 31375
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401346E RID: 78958
			public static VerifyTableAction <0>__Verify;
		}
	}
}
