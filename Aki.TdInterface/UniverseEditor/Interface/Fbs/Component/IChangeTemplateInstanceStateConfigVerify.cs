using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A7 RID: 21671
	public static class IChangeTemplateInstanceStateConfigVerify
	{
		// Token: 0x06022202 RID: 139778 RVA: 0x004B43F8 File Offset: 0x004B25F8
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

		// Token: 0x020082FC RID: 33532
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014505 RID: 83205
			public static VerifyTableAction <0>__Verify;
		}
	}
}
