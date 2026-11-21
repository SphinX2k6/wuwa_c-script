using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F53 RID: 32595
	public static class TMoveDriveModeVerify
	{
		// Token: 0x0603AC52 RID: 240722 RVA: 0x007E6AAC File Offset: 0x007E4CAC
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
