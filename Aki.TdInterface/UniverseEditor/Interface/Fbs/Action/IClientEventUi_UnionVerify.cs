using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063BD RID: 25533
	public static class IClientEventUi_UnionVerify
	{
		// Token: 0x0602C2AE RID: 180910 RVA: 0x0061087C File Offset: 0x0060EA7C
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
