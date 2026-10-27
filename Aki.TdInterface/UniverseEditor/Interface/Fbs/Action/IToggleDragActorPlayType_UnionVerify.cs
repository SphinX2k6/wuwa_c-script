using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007405 RID: 29701
	public static class IToggleDragActorPlayType_UnionVerify
	{
		// Token: 0x06035F5A RID: 221018 RVA: 0x007579DC File Offset: 0x00755BDC
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
