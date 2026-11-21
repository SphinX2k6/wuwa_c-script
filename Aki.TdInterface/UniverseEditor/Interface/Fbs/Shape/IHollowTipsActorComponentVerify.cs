using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004033 RID: 16435
	public static class IHollowTipsActorComponentVerify
	{
		// Token: 0x060168FA RID: 92410 RVA: 0x0033A614 File Offset: 0x00338814
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

		// Token: 0x020080E4 RID: 32996
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401416A RID: 82282
			public static VerifyTableAction <0>__Verify;
		}
	}
}
