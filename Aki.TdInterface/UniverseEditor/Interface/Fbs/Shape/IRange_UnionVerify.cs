using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C30 RID: 15408
	public static class IRange_UnionVerify
	{
		// Token: 0x06015448 RID: 87112 RVA: 0x0031416C File Offset: 0x0031236C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRangeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICircleRangeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBoxRangeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICylinderVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
