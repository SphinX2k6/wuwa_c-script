using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DF RID: 30687
	public static class TToggleDragActorPlayVerify
	{
		// Token: 0x06037A99 RID: 227993 RVA: 0x00786EC0 File Offset: 0x007850C0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IToggleDragActorPlayEnableVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IToggleDragActorPlayDisableVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
