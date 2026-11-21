using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F2 RID: 30962
	public static class ISkiConfigType_UnionVerify
	{
		// Token: 0x0603685E RID: 223326 RVA: 0x0074C9D4 File Offset: 0x0074ABD4
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
