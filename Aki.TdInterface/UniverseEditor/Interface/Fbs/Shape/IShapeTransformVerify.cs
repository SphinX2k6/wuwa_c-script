using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200404E RID: 16462
	public static class IShapeTransformVerify
	{
		// Token: 0x060169FA RID: 92666 RVA: 0x0033C4AC File Offset: 0x0033A6AC
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

		// Token: 0x020080E7 RID: 32999
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401416E RID: 82286
			public static VerifyTableAction <0>__Verify;
		}
	}
}
