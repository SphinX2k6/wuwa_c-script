using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006215 RID: 25109
	public static class TComponentDataVerify
	{
		// Token: 0x0602AC2C RID: 175148 RVA: 0x005D75A4 File Offset: 0x005D57A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = TComponentDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TComponentDataVerify.<>O.<0>__Verify = new VerifyUnionAction(IComponentBase_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084FF RID: 34047
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401485F RID: 84063
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
