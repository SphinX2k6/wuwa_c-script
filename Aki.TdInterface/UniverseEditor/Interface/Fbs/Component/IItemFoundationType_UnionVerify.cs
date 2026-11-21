using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A22 RID: 23074
	public static class IItemFoundationType_UnionVerify
	{
		// Token: 0x06025B21 RID: 154401 RVA: 0x0052AD3C File Offset: 0x00528F3C
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
