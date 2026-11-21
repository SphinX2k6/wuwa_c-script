using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2E RID: 27182
	public static class IClientEventUi_UnionVerify
	{
		// Token: 0x0602EA10 RID: 190992 RVA: 0x0065B8B4 File Offset: 0x00659AB4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientEventUiVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientEventUiPlayPianoVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientEventUiFlyingFlowerVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
