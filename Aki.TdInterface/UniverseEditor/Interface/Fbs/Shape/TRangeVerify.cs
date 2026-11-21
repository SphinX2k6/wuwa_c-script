using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200408D RID: 16525
	public static class TRangeVerify
	{
		// Token: 0x06016C26 RID: 93222 RVA: 0x003401A0 File Offset: 0x0033E3A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBoxRangeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICircleRangeVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
