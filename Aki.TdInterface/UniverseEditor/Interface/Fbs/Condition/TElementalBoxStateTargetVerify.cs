using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005243 RID: 21059
	public static class TElementalBoxStateTargetVerify
	{
		// Token: 0x060212AA RID: 135850 RVA: 0x004941BC File Offset: 0x004923BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IElementalBoxStateFoundationSelfTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IElementalBoxStateFoundationTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IElementalBoxStatePlayerTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
