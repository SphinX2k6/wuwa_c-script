using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200639C RID: 25500
	public static class IClientEventFlyingFlowerEvent_UnionVerify
	{
		// Token: 0x0602C1DC RID: 180700 RVA: 0x0060F324 File Offset: 0x0060D524
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientEventFlyingFlowerUpdateSubtitleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientEventFlyingFlowerEventVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
