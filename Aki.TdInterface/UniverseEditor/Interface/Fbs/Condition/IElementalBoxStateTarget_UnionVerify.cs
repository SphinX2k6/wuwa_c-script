using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C0F RID: 19471
	public static class IElementalBoxStateTarget_UnionVerify
	{
		// Token: 0x0601ED66 RID: 126310 RVA: 0x004514FC File Offset: 0x0044F6FC
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
