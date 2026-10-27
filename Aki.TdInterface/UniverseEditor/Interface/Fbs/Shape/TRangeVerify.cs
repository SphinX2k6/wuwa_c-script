using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C7B RID: 15483
	public static class TRangeVerify
	{
		// Token: 0x060156F2 RID: 87794 RVA: 0x00318FB4 File Offset: 0x003171B4
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
