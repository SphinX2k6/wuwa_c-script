using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006275 RID: 25205
	public static class TItemFoundationVerify
	{
		// Token: 0x0602AE42 RID: 175682 RVA: 0x005DAB34 File Offset: 0x005D8D34
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
