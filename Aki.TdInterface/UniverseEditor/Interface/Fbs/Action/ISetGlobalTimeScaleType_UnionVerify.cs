using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFD RID: 28669
	public static class ISetGlobalTimeScaleType_UnionVerify
	{
		// Token: 0x06032B5D RID: 207709 RVA: 0x006D7960 File Offset: 0x006D5B60
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
