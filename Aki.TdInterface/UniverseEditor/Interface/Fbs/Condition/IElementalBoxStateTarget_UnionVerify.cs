using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050FC RID: 20732
	public static class IElementalBoxStateTarget_UnionVerify
	{
		// Token: 0x0602094C RID: 133452 RVA: 0x00484B64 File Offset: 0x00482D64
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IElementalBoxStateTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IElementalBoxStatePlayerTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IElementalBoxStateFoundationTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IElementalBoxStateFoundationSelfTargetVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IElementalBoxStateSpecifiedTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
