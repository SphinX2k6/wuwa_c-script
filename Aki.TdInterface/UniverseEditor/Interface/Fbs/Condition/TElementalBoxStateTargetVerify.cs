using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D47 RID: 19783
	public static class TElementalBoxStateTargetVerify
	{
		// Token: 0x0601F661 RID: 128609 RVA: 0x004601E8 File Offset: 0x0045E3E8
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
