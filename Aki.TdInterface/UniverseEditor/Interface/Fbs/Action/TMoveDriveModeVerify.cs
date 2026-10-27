using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772A RID: 30506
	public static class TMoveDriveModeVerify
	{
		// Token: 0x06037717 RID: 227095 RVA: 0x00781B1C File Offset: 0x0077FD1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPositionDrivenMoveDriveModeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInputDrivenMoveDriveModeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
