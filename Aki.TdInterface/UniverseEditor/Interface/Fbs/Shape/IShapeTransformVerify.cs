using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C3F RID: 15423
	public static class IShapeTransformVerify
	{
		// Token: 0x060154E6 RID: 87270 RVA: 0x0031560C File Offset: 0x0031380C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShapeTransformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShapeTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IShapeTransformVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IShapeTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IShapeTransformVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IShapeTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020078A3 RID: 30883
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013112 RID: 78098
			public static VerifyTableAction <0>__Verify;
		}
	}
}
