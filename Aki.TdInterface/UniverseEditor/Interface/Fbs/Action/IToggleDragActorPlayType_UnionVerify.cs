using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BEF RID: 31727
	public static class IToggleDragActorPlayType_UnionVerify
	{
		// Token: 0x0603930D RID: 234253 RVA: 0x007BA150 File Offset: 0x007B8350
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IToggleDragActorPlayTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IToggleDragActorPlayEnableVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IToggleDragActorPlayDisableVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
