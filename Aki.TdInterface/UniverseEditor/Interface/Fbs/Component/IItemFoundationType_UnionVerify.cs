using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549C RID: 21660
	public static class IItemFoundationType_UnionVerify
	{
		// Token: 0x06023A69 RID: 146025 RVA: 0x004EDCC8 File Offset: 0x004EBEC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IItemFoundationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICategoryMatchingFoundationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBuildingBlockFoundationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPulseDeviceFoundationVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRangeAdsorptionFoundationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
