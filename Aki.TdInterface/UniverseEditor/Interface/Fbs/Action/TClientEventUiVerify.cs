using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E84 RID: 32388
	public static class TClientEventUiVerify
	{
		// Token: 0x0603A7B2 RID: 239538 RVA: 0x007DF374 File Offset: 0x007DD574
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
