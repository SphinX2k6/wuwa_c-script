using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C50 RID: 23632
	public static class TItemFoundationVerify
	{
		// Token: 0x06028834 RID: 165940 RVA: 0x0059291C File Offset: 0x00590B1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBuildingBlockFoundationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICategoryMatchingFoundationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPulseDeviceFoundationVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
