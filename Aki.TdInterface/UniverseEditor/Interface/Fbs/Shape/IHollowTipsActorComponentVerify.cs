using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C27 RID: 15399
	public static class IHollowTipsActorComponentVerify
	{
		// Token: 0x06015404 RID: 87044 RVA: 0x00313A8C File Offset: 0x00311C8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHollowTipsActorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHollowTipsActorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IShapeTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHollowTipsActorComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IHollowTipsActorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IShapeTransformVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078A0 RID: 30880
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401310E RID: 78094
			public static VerifyTableAction <0>__Verify;
		}
	}
}
