using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BDD RID: 31709
	public static class IToggleAirWallType_UnionVerify
	{
		// Token: 0x06039267 RID: 234087 RVA: 0x007B8EB4 File Offset: 0x007B70B4
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
