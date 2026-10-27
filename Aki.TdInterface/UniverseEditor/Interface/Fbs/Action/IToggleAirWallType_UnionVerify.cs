using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F3 RID: 29683
	public static class IToggleAirWallType_UnionVerify
	{
		// Token: 0x06035EB4 RID: 220852 RVA: 0x00756740 File Offset: 0x00754940
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IToggleAirWallTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenAirWallVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseAirWallVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
