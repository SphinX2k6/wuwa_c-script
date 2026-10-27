using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007126 RID: 28966
	public static class ISkiConfigType_UnionVerify
	{
		// Token: 0x060335BC RID: 210364 RVA: 0x006EC3C8 File Offset: 0x006EA5C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISkiConfigTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenSkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseSkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAccelerateSkiConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
