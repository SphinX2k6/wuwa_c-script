using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200801A RID: 32794
	public static class TToggleDragActorPlayVerify
	{
		// Token: 0x0603B02C RID: 241708 RVA: 0x007EC670 File Offset: 0x007EA870
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
