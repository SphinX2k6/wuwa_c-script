using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C6 RID: 30662
	public static class ISetGlobalTimeScaleType_UnionVerify
	{
		// Token: 0x06035DC3 RID: 220611 RVA: 0x007375A4 File Offset: 0x007357A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetGlobalTimeScaleTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenGlobalTimeScaleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseGlobalTimeScaleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
