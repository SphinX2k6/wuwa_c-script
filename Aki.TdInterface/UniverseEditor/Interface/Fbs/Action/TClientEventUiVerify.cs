using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007676 RID: 30326
	public static class TClientEventUiVerify
	{
		// Token: 0x0603730D RID: 226061 RVA: 0x0077B278 File Offset: 0x00779478
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientEventUiPlayPianoVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientEventUiFlyingFlowerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
