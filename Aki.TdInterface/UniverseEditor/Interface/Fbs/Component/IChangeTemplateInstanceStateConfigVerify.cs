using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F78 RID: 20344
	public static class IChangeTemplateInstanceStateConfigVerify
	{
		// Token: 0x060204B0 RID: 132272 RVA: 0x0047E408 File Offset: 0x0047C608
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChangeTemplateInstanceStateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeTemplateInstanceStateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AA6 RID: 31398
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401348F RID: 78991
			public static VerifyTableAction <0>__Verify;
		}
	}
}
